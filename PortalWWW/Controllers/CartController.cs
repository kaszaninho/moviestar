using BusinessLogic;
using DatabaseAPI.Data;
using DatabaseAPI.Models.CinemaMovie;
using DatabaseAPI.Models.General;
using DatabaseAPI.Models.Helpers;
using InvoiceSdk.Models;
using InvoiceSdk.Models.Payments;
using InvoiceSdk.Renderer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PortalWWW.Models;
using Stripe;
using Stripe.Checkout;

namespace PortalWWW.Controllers
{
    public class CartController : Controller
    {
        private readonly DatabaseAPIContext dbContext;

        public CartController(DatabaseAPIContext context)
        {
            dbContext = context;
        }

        [Authorize]
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

        [HttpGet]
        public ActionResult Cart()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpPost]
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

        [Authorize]
        public async Task<ActionResult> ChoosePayment()
        {
            CartBusinessLogic cartBusinessLogic = new CartBusinessLogic(this.dbContext, this.HttpContext);
            var cartInformation = new CartInformation
            {
                CartElements = await cartBusinessLogic.GetCartElements(),
                PriceTotal = await cartBusinessLogic.CalculateSum()
            };
            var listForBag = dbContext.PaymentMethod.Select(method => new
            {
                method.Id,
                method.Name
            }).ToList();
            ViewBag.PaymentMethods = new SelectList(listForBag, "Id", "Name");
            return View(cartInformation);
        }

        public async Task<IActionResult> OrderConfirmed(Guid invoiceId)
        {
            var invoice = dbContext.Invoice.Include(inv => inv.PaymentMethod).First(inv => inv.InvoiceId == invoiceId);
            var service = new SessionService();
            Session session = service.Get(invoice.StripeSessionId);
            if (session.PaymentStatus.ToLower() == "paid")
            {
                UpdateStripePaymentID(invoiceId, session.Id, session.PaymentIntentId);
                UpdateStatus(invoiceId, Constans.OrderStatus_Retrieved, Constans.PaymentStatus_Approved);
                dbContext.SaveChanges();
            }
            CartBusinessLogic cartBusinessLogic = new CartBusinessLogic(this.dbContext, this.HttpContext);
            var cartInformation = new CartInformation
            {
                CartElements = await cartBusinessLogic.GetCartElements(),
                PriceTotal = await cartBusinessLogic.CalculateSum()
            };
            await cartBusinessLogic.ClearCart(cartInformation.CartElements.ToArray());
            HttpContext.Session.Clear();
            return View(invoice);
        }

        public async Task<IActionResult> OrderCancelled(Guid invoiceId)
        {
            var invoice = dbContext.Invoice.Include(inv => inv.PaymentMethod).First(inv => inv.InvoiceId == invoiceId);
            return View(invoice);
        }

        [Authorize]
        public async Task<ActionResult> ProcessPayment(int paymentMethodId)
        {
            //add tickets to db based on screeningseats
            //add invoice to db based on screeningseats -> movies
            //make screeningseats as TAKEN in DB
            //save db

            CartBusinessLogic cartBusinessLogic = new CartBusinessLogic(this.dbContext, this.HttpContext);
            var userId = this.dbContext.User.First(x => x.Email == this.HttpContext.User.Identity.Name).Id;
            var cartInformation = new CartInformation
            {
                CartElements = await cartBusinessLogic.GetCartElements(),
                PriceTotal = await cartBusinessLogic.CalculateSum()
            };
            var invoice = new InvoiceSdk.Models.Invoice()
            {
                Id = Guid.NewGuid(),
                Number = new Random().Next(0, int.MaxValue),
                InvoiceCurrency = new InvoiceCurrencySymbol(InvoiceCurrency.Euro),
                SellerAddress = InvoiceGenerator.generateAddressForCinema(),
                CustomerAddress = InvoiceGenerator.generateAddressForCustomer("1", "1", "1", "1", "1", "1")
            };
            var dbInvoice = new DatabaseAPI.Models.General.Invoice
            {
                InvoiceId = invoice.Id,
                CreatedAt = DateTime.Now,
                ModifiedAt = DateTime.Now,
                IsActive = true,
                Sum = cartInformation.PriceTotal,
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


            var itemsOnInvoice = new List<InvoiceSdk.Models.InvoiceItem>();
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
                    Invoice = dbInvoice
                };
                TicketGenerator.GenerateTicket(ticketInvoice);
                dbContext.Ticket.Add(ticket);
                dbContext.ScreeningSeat.First(item => item.Id == element.ScreeningSeat.Id).IsTaken = true;
                if (itemsOnInvoice.Exists(item => item.Name == ticketInvoice.MovieName))
                {
                    itemsOnInvoice.First(item => item.Name == ticketInvoice.MovieName).Quantity++;
                }
                else
                {
                    itemsOnInvoice.Add(new InvoiceSdk.Models.InvoiceItem()
                    {
                        Name = ticketInvoice.MovieName,
                        InvoiceId = invoice.Id,
                        Quantity = 1,
                        UnitPriceWithoutVat = element.ScreeningSeat.Screening.Movie.TicketPrice ?? Decimal.Zero,
                        VatPercentage = 23
                    });
                }
            }
            dbContext.Add(dbInvoice);
            await dbContext.SaveChangesAsync();
            invoice.Items = itemsOnInvoice;
            invoice.Payments = new List<Payment>()
            {
                InvoiceGenerator.generatePayment(invoice.Id, itemsOnInvoice.Sum(item => item.Quantity * item.UnitPriceWithoutVat))
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


                var service = new SessionService();
                Session session = service.Create(options);
                UpdateStripePaymentID(dbInvoice.InvoiceId, session.Id, session.PaymentIntentId);
                dbContext.SaveChanges();
                Response.Headers.Add("Location", session.Url);
                return new StatusCodeResult(303);
            }



            IInvoiceRenderer renderer = new InvoiceRenderer();
            renderer.RenderInvoice(invoice, InvoiceGenerator.generateConfiguration()).Generate();
            // "C:/Users/pre12/Desktop/Invoice" + new Random().Next(100) + ".pdf"
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

        public void GenerateRaport()
        {

        }
    }
}
