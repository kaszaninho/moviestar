using BusinessLogic;
using BusinessLogic.Helpers;
using DatabaseAPI.Data;
using DatabaseAPI.Models.CinemaMovie;
using HelperProject;
using InvoiceSdk.Models;
using InvoiceSdk.Models.Payments;
using InvoiceSdk.Renderer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PortalWWW.Models;
using ServiceStack;
using Stripe.Checkout;
using static PortalWWW.Helpers.StripeHelper;
using InvoiceItem = InvoiceSdk.Models.InvoiceItem;

namespace PortalWWW.Controllers
{
    [Route("[controller]")]
    [Authorize]
    public class CartController : Controller
    {
        private readonly DatabaseAPIContext dbContext;

        public CartController(DatabaseAPIContext context)
        {
            dbContext = context;
        }

        [HttpGet("Index")]
        public async Task<IActionResult> Index()
        {
            CartBusinessLogic cartBusinessLogic = new CartBusinessLogic(this.dbContext, this.HttpContext);
            var cartInformation = new CartInformation
            {
                CartElements = await cartBusinessLogic.GetCartElements(),
                PriceTotal = await cartBusinessLogic.CalculateSum()
            };
            return View(cartInformation);
        }

        [HttpGet("Cart")]
        public ActionResult Cart()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [Route("[controller]/AddToCart")]
        public ActionResult AddToCart(string[] screeningSeats)
        {
            var seats = dbContext.ScreeningSeat.Include(x => x.Screening).ThenInclude(x => x.Movie).Where(item => screeningSeats.Contains(item.Id.ToString())).ToList();
            CartBusinessLogic cartBusinessLogic = new CartBusinessLogic(dbContext, this.HttpContext);
            foreach (var seat in seats)
            {
                cartBusinessLogic.AddToCart(seat);
            }
            return RedirectToAction("Index");
        }

        [HttpPost("RemoveFromCart")]
        public async Task<IActionResult> RemoveFromCart(int cartElementId)
        {
            CartBusinessLogic cartBusinessLogic = new CartBusinessLogic(dbContext, this.HttpContext);
            var cartElements = await cartBusinessLogic.GetCartElements();
            var searchedCartElement = cartElements.First(x => x.Id == cartElementId);
            if (searchedCartElement == null)
            {
                return NotFound();
            }
            await cartBusinessLogic.RemoveFromCart(searchedCartElement);
            return RedirectToAction("Index");
        }

        [HttpPost("AddCoupon")]
        public async Task<IActionResult> AddCoupon(string couponName)
        {
            if (!couponName.IsNullOrEmpty())
            {
                var coupon = dbContext.Coupon.Where(item => item.Name == couponName).ToList();
                if (coupon.Any())
                {
                    CartBusinessLogic cartBusinessLogic = new CartBusinessLogic(this.dbContext, this.HttpContext);
                    var couponVal = cartBusinessLogic.CheckCoupon();
                    if (couponVal == null)
                    {
                        dbContext.CartElement.Add(new CartElement
                        {
                            Coupon = coupon.FirstOrDefault(),
                            SessionId = cartBusinessLogic.GetSessionId()
                        });
                        dbContext.SaveChanges();
                    }
                }
            }
            return RedirectToAction("ChoosePayment");
        }

        [HttpGet("ChoosePayment")]
        public async Task<ActionResult> ChoosePayment()
        {
            CartBusinessLogic cartBusinessLogic = new CartBusinessLogic(this.dbContext, this.HttpContext);
            var cartInformation = new CartInformation
            {
                CartElements = await cartBusinessLogic.GetCartElements(),
                PriceTotal = await cartBusinessLogic.CalculateSum(),
                Coupon = await cartBusinessLogic.CheckCoupon()
            };
            if (cartInformation.Coupon != null)
            {
                cartInformation.CouponDiscount = (decimal)cartInformation.Coupon.Discount / 100 * cartInformation.PriceTotal;
            }
            var listForBag = dbContext.PaymentMethod.Select(method => new
            {
                method.Id,
                method.Name
            }).ToList();
            ViewBag.PaymentMethods = new SelectList(listForBag, "Id", "Name");
            return View(cartInformation);
        }

        [HttpGet("OrderConfirmed")]
        public async Task<IActionResult> OrderConfirmed(Guid invoiceId)
        {
            var invoice = dbContext.Invoice.Include(inv => inv.PaymentMethod).Include(inv => inv.Coupon).First(inv => inv.InvoiceId == invoiceId);
            if (invoice.PaymentMethod.Name == "Stripe")
            {
                var service = new SessionService();
                Session session = service.Get(invoice.StripeSessionId);
                if (session.PaymentStatus.ToLower() == "paid")
                {
                    UpdateStripePaymentID(invoiceId, session.Id, session.PaymentIntentId);
                    UpdateStatus(invoiceId, Constans.OrderStatus_Retrieved, Constans.PaymentStatus_Approved);
                    dbContext.SaveChanges();
                }
            }
            CartBusinessLogic cartBusinessLogic = new CartBusinessLogic(this.dbContext, this.HttpContext);
            var cartInformation = new CartInformation
            {
                CartElements = await cartBusinessLogic.GetCartElements(),
                PriceTotal = await cartBusinessLogic.CalculateSum(),
            };
            await cartBusinessLogic.ClearCart(cartInformation.CartElements.ToArray());
            await cartBusinessLogic.ClearCoupon(invoice.CouponId);
            HttpContext.Session.Clear();
            return View(invoice);
        }

        [HttpGet("OrderCancelled")]
        public async Task<IActionResult> OrderCancelled(Guid invoiceId)
        {
            var invoice = dbContext.Invoice.Include(inv => inv.PaymentMethod).First(inv => inv.InvoiceId == invoiceId);
            return View(invoice);
        }

        [HttpPost("ProcessPayment")]
        public async Task<ActionResult> ProcessPayment(int paymentMethodId)
        {
            //add tickets to db based on screeningseats
            //add invoice to db based on screeningseats -> movies
            //make screeningseats as TAKEN in DB
            //save db
            var invoiceTemplateInfo = await dbContext.InvoiceTemplateInformation.FirstOrDefaultAsync();

            CartBusinessLogic cartBusinessLogic = new CartBusinessLogic(this.dbContext, this.HttpContext);
            var user = this.dbContext.User.Include(u => u.Address).ThenInclude(u => u.Country).First(x => x.Email == this.HttpContext.User.Identity.Name);
            var userId = user.Id;
            var cartInformation = new CartInformation
            {
                CartElements = await cartBusinessLogic.GetCartElements(),
                PriceTotal = await cartBusinessLogic.CalculateSum(),
                Coupon = await cartBusinessLogic.CheckCoupon()
            };
            var invoice = new Invoice()
            {
                Id = Guid.NewGuid(),
                Number = new Random().Next(0, int.MaxValue),
                InvoiceCurrency = new InvoiceCurrencySymbol(InvoiceCurrency.Euro),
                DueAt = DateTime.Now.AddDays(7),
                IssuedAt = DateTime.Now,
                SellerAddress = InvoiceGenerator.generateAddressForCinema(invoiceTemplateInfo.AddressStreet, invoiceTemplateInfo.AddressCountry,
                invoiceTemplateInfo.AddressCity, invoiceTemplateInfo.AddressZipCode, invoiceTemplateInfo.AddressPhone, invoiceTemplateInfo.AddressCompanyName,
                invoiceTemplateInfo.AddressEmail, invoiceTemplateInfo.AddressState),
                CustomerAddress = InvoiceGenerator.generateAddressForCustomer(user.Address.StreetName + " " + user.Address.HouseNumber,
                user.Address.Country.Name, user.Address.City, user.Address.EirCode, user.PhoneNumber)
            };
            var dbInvoice = new DatabaseAPI.Models.General.Invoice
            {
                InvoiceId = invoice.Id,
                CreatedAt = DateTime.Now,
                ModifiedAt = DateTime.Now,
                IsActive = true,
                TicketSum = cartInformation.PriceTotal,
                PaymentMethodId = paymentMethodId,
                UserId = userId
            };

            // checking payment method
            var paymentMethod = dbContext.PaymentMethod.First(method => method.Id == paymentMethodId);

            if (paymentMethod == null || paymentMethod.Name != "Stripe")
            {
                dbInvoice.PaymentStatus = Constans.PaymentStatus_Approved;
                dbInvoice.OrderStatus = Constans.OrderStatus_Retrieved;
                invoice.Status = InvoiceStatus.Paid;
            }
            else
            {
                dbInvoice.PaymentStatus = Constans.PaymentStatus_Pending;
                dbInvoice.OrderStatus = Constans.OrderStatus_Pending;
                invoice.Status = InvoiceStatus.Pending;
            }


            var itemsOnInvoice = new List<InvoiceItem>();
            foreach (var element in cartInformation.CartElements)
            {
                var ticketInvoice = new TicketInvoiceModel()
                {
                    Id = element.Id,
                    MovieName = element.ScreeningSeat.Screening.Movie.Name,
                    seatCode = element.ScreeningSeat.Name,
                    RoomNumber = element.ScreeningSeat.Screening.Screen.RoomNumber,
                    StartDate = element.ScreeningSeat.Screening.StartDate,
                };
                var ticket = new Ticket()
                {
                    ScreeningSeat = element.ScreeningSeat,
                    ScreeningSeatId = element.ScreeningSeatId,
                    Invoice = dbInvoice,
                    CreatedAt = DateTime.Now,
                    ModifiedAt = DateTime.Now,
                    Name = element.ScreeningSeat.Screening.Movie.Name,
                    IsActive = true
                };
                TicketGenerator.GenerateTicket(ticketInvoice, null);
                dbContext.Ticket.Add(ticket);
                dbContext.ScreeningSeat.First(item => item.Id == element.ScreeningSeat.Id).IsTaken = true;
                if (itemsOnInvoice.Exists(item => item.Name == ticketInvoice.MovieName))
                {
                    itemsOnInvoice.First(item => item.Name == ticketInvoice.MovieName).Quantity++;
                }
                else
                {
                    itemsOnInvoice.Add(new InvoiceItem()
                    {
                        Name = ticketInvoice.MovieName,
                        InvoiceId = invoice.Id,
                        Quantity = 1,
                        UnitPriceWithoutVat = element.ScreeningSeat.Screening.Movie.TicketPrice ?? Decimal.Zero,
                        VatPercentage = 23
                    });
                }
            }
            if (cartInformation.Coupon != null)
            {
                dbInvoice.Coupon = cartInformation.Coupon;
                dbInvoice.CouponDiscount = dbInvoice.TicketSum * ((decimal)dbInvoice.Coupon.Discount / 100);
                dbInvoice.TotalSum = dbInvoice.TicketSum - dbInvoice.CouponDiscount;
                itemsOnInvoice.Add(new InvoiceItem
                {
                    Name = $"Coupon discount - {dbInvoice.Coupon.Name}",
                    InvoiceId = invoice.Id,
                    UnitPriceWithoutVat = -dbInvoice.CouponDiscount ?? Decimal.Zero,
                    VatPercentage = 23,
                    Quantity = 1
                });
            }
            else
            {
                dbInvoice.TotalSum = dbInvoice.TicketSum;
            }
            await dbContext.AddAsync(dbInvoice);
            await dbContext.SaveChangesAsync();
            invoice.Items = itemsOnInvoice;
            invoice.Payments = new List<Payment>()
            {
                InvoiceGenerator.generatePayment(invoice.Id, itemsOnInvoice.Sum(item => item.Quantity * item.UnitPriceWithoutVat), paymentMethod.Name)
            };

            if (paymentMethod != null && paymentMethod.Name == "Stripe")
            {

                //stripe logic
                var domain = Request.Scheme + "://" + Request.Host.Value + "/";
                var options = new SessionCreateOptions
                {
                    SuccessUrl = domain + $"cart/OrderConfirmed?invoiceId={dbInvoice.InvoiceId}",
                    CancelUrl = domain + $"cart/OrderCancelled?invoiceId={dbInvoice.InvoiceId}",
                    LineItems = new List<SessionLineItemOptions>(),
                    Mode = "payment",
                };

                foreach (var item in itemsOnInvoice)
                {
                    if (item.Name.StartsWith("Coupon")) continue;
                    var sessionLineItem = new SessionLineItemOptions
                    {
                        PriceData = new SessionLineItemPriceDataOptions
                        {
                            UnitAmount = (long)(item.PriceWithVat * 100), // $20.50 => 2050
                            Currency = "pln",
                            ProductData = new SessionLineItemPriceDataProductDataOptions
                            {
                                Name = item.Name
                            }
                        },
                        Quantity = item.Quantity
                    };
                    options.LineItems.Add(sessionLineItem);
                }
                //check if discount applies
                if (cartInformation.Coupon != null)
                {
                    var discount = CheckCoupon(cartInformation.Coupon);
                    if (discount != null && discount.Count > 0)
                    {
                        options.Discounts = discount;
                    }
                }


                var service = new SessionService();
                Session session = service.Create(options);
                UpdateStripePaymentID(dbInvoice.InvoiceId, session.Id, session.PaymentIntentId);
                dbContext.SaveChanges();
                IInvoiceRenderer rerer = new InvoiceRenderer();
                string path2 = "wwwroot//reports//Invoice" + dbInvoice.Id + ".pdf";
                rerer.RenderInvoice(invoice, InvoiceGenerator.generateConfiguration(invoiceTemplateInfo.Font, invoiceTemplateInfo.HexHeaderColor,
                    invoiceTemplateInfo.SellerHeader, invoiceTemplateInfo.BuyerHeader, invoiceTemplateInfo.ItemHeader, invoiceTemplateInfo.AlertWithoutItems,
                    invoiceTemplateInfo.AlertItemsHeader, invoiceTemplateInfo.AlertWithoutPayments, invoiceTemplateInfo.AlertPaymentHeader, invoiceTemplateInfo.PaymentHeader,
                    invoiceTemplateInfo.FinalText)).Save(path2);
                Response.Headers.Add("Location", session.Url);
                return new StatusCodeResult(303);
            }



            IInvoiceRenderer renderer = new InvoiceRenderer();
            string path = "wwwroot//reports//Invoice" + dbInvoice.Id + ".pdf";
            renderer.RenderInvoice(invoice, InvoiceGenerator.generateConfiguration(invoiceTemplateInfo.Font, invoiceTemplateInfo.HexHeaderColor,
                invoiceTemplateInfo.SellerHeader, invoiceTemplateInfo.BuyerHeader, invoiceTemplateInfo.ItemHeader, invoiceTemplateInfo.AlertWithoutItems,
                invoiceTemplateInfo.AlertItemsHeader, invoiceTemplateInfo.AlertWithoutPayments, invoiceTemplateInfo.AlertPaymentHeader, invoiceTemplateInfo.PaymentHeader,
                invoiceTemplateInfo.FinalText)).Save(path);
            return RedirectToAction("OrderConfirmed", new { invoiceId = dbInvoice.InvoiceId });
        }

        private void UpdateStripePaymentID(Guid invoiceId, string stripeSessionId, string stripePaymentIntentId)
        {
            var invoice = dbContext.Invoice.First(inv => inv.InvoiceId == invoiceId);
            if (!string.IsNullOrEmpty(stripeSessionId))
            {
                invoice.StripeSessionId = stripeSessionId;
            }
            if (!string.IsNullOrEmpty(stripePaymentIntentId))
            {
                invoice.StripePaymentIntentId = stripePaymentIntentId;
                invoice.ModifiedAt = DateTime.Now;
                // TODO: dodac payment date
            }
        }
        private void UpdateStatus(Guid invoiceId, string orderStatus, string? paymentStatus = null)
        {
            var invoice = dbContext.Invoice.First(inv => inv.InvoiceId == invoiceId);
            if (invoice != null)
            {
                invoice.OrderStatus = orderStatus;
                if (!string.IsNullOrEmpty(paymentStatus))
                {
                    invoice.PaymentStatus = paymentStatus;
                }
            }
        }
    }
}
