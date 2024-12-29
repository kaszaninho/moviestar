using BusinessLogic;
using DatabaseAPI.Data;
using DatabaseAPI.Models.CinemaMovie;
using DatabaseAPI.Models.Helpers;
using InvoiceSdk.Models;
using InvoiceSdk.Models.Payments;
using InvoiceSdk.Renderer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortalWWW.Models;

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
            return View(cartInformation);
        }

        [Authorize]
        public async Task<ActionResult> ProcessPayment(int paymentMethod)
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
            var invoice = new Invoice()
            {
                Id = Guid.NewGuid(),
                Number = new Random().Next(0, int.MaxValue),
                InvoiceCurrency = new InvoiceCurrencySymbol(InvoiceCurrency.Euro),
                Status = InvoiceStatus.Paid,
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
                PaymentMethodId = paymentMethod,
                UserId = userId
            };
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
                    Invoice = dbInvoice
                };
                TicketGenerator.GenerateTicket(ticketInvoice);
                dbContext.Ticket.Add(ticket);
                dbContext.ScreeningSeat.First(item => item.Id == element.ScreeningSeat.Id).IsTaken = true;
                if(itemsOnInvoice.Exists(item => item.Name == ticketInvoice.MovieName))
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
            await dbContext.SaveChangesAsync();
            invoice.Items = itemsOnInvoice;
            invoice.Payments = new List<Payment>()
            {
                InvoiceGenerator.generatePayment(invoice.Id, itemsOnInvoice.Sum(item => item.Quantity * item.UnitPriceWithoutVat))
            };
            IInvoiceRenderer renderer = new InvoiceRenderer();
            renderer.RenderInvoice(invoice, InvoiceGenerator.generateConfiguration()).Generate();
            // "C:/Users/pre12/Desktop/Invoice" + new Random().Next(100) + ".pdf"
            await cartBusinessLogic.ClearCart(cartInformation.CartElements.ToArray());
            return RedirectToAction("Cart");
        }

        public void GenerateRaport()
        {

        }
    }
}
