using DatabaseAPI.Data;
using DatabaseAPI.Models.CinemaMovie;
using DatabaseAPI.Models.General;
using DatabaseAPI.ViewModels;
using HelperProject;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatabaseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly DatabaseAPIContext _context;

        public InvoiceController(DatabaseAPIContext context)
        {
            _context = context;
        }

        // GET: api/Invoice
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Invoice>>> GetInvoice()
        {
            return await _context.Invoice.ToListAsync();
        }


        // GET: invoicesforuser/5
        [HttpGet("invoicesforuser/{userId}")]
        public async Task<ActionResult<IEnumerable<MiniInvoiceViewModel>>> GetInvoicesForUser(string userId)
        {
            var invList = await _context.Invoice
                .Include(inv => inv.Tickets).ThenInclude(inv => inv.ScreeningSeat).ThenInclude(inv => inv.Screening).ThenInclude(inv => inv.Movie)
                .Where(inv => inv.UserId == userId).ToListAsync();
            var invViewModel = invList.Select(inv => new MiniInvoiceViewModel
            {
                CreatedAt = inv.CreatedAt,
                InvoiceId = inv.InvoiceId,
                OrderStatus = inv.OrderStatus,
                PaymentStatus = inv.PaymentStatus,
                TotalSum = inv.TotalSum
            }).ToList();
            return invViewModel;
        }

        // GET: api/Invoice/5
        [HttpGet("{invoiceId}")]
        public async Task<ActionResult<InvoiceViewModel>> GetInvoice(string invoiceId)
        {
            var invoice = await _context.Invoice.Include(inv => inv.Coupon)
                .Include(inv => inv.User).ThenInclude(inv => inv.Address).ThenInclude(inv => inv.Country)
                .Include(inv => inv.Tickets).ThenInclude(inv => inv.ScreeningSeat).ThenInclude(inv => inv.Screening).ThenInclude(inv => inv.Movie)
                .FirstAsync(inv => inv.InvoiceId.ToString() == invoiceId);

            if (invoice == null)
            {
                return NotFound();
            }
            var invoiceViewModel = new InvoiceViewModel
            {
                InvoiceId = invoice.InvoiceId,
                TotalSum = invoice.TotalSum,
                CouponDiscount = invoice.CouponDiscount,
                CreatedAt = invoice.CreatedAt,
                OrderStatus = invoice.OrderStatus,
                PaymentStatus = invoice.PaymentStatus,
                TicketSum = invoice.TicketSum,
                Coupon = invoice.Coupon?.Name ?? "N/A",
                BuyerAddress = new AddressViewModel
                {
                    Street = $"{invoice.User.Address.StreetName} {invoice.User.Address.HouseNumber}",
                    City = invoice.User.Address.City,
                    Country = invoice.User.Address.Country.Name,
                    EirCode = invoice.User.Address.EirCode
                },
                Tickets = invoice.Tickets.Select(ticket => new TicketViewModel
                {
                    EndDate = ticket.ScreeningSeat.Screening.EndDate,
                    StartDate = ticket.ScreeningSeat.Screening.StartDate,
                    SeatNumber = ticket.ScreeningSeat.Name,
                    MovieId = ticket.ScreeningSeat.Screening.MovieId,
                    MovieName = ticket.ScreeningSeat.Screening.Movie.Name
                })
            };
            return invoiceViewModel;
        }


        // POST: api/Invoice
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<bool>> PostInvoice([FromBody] InvoiceCreationViewModel invoiceRequest)
        {
            if (invoiceRequest == null)
            {
                return BadRequest("Empty request!");
            }

            var screeningSeats = await _context.ScreeningSeat.Where(x => invoiceRequest.ScreeningSeatIds.Contains(x.Id)).ToListAsync();

            if (!screeningSeats.Any())
            {
                return BadRequest("No seats were chosen!");
            }
            if (screeningSeats.Any(x => x.IsTaken ?? false))
            {
                return BadRequest("Some of the seats are already taken!");
            }

            screeningSeats.ForEach(x => x.IsTaken = true);

            var tickets = invoiceRequest.ScreeningSeatIds?.Select(x => new Ticket
            {
                CreatedAt = DateTime.Now,
                ModifiedAt = DateTime.Now,
                InvoiceId = invoiceRequest.InvoiceId,
                ScreeningSeatId = x
            }).ToList();

            var invoice = new Invoice
            {
                UserId = invoiceRequest.UserId,
                InvoiceId = invoiceRequest.InvoiceId,
                CouponId = invoiceRequest.CouponId,
                CouponDiscount = invoiceRequest.CouponDiscount,
                CreatedAt = DateTime.Now,
                ModifiedAt = DateTime.Now,
                IsActive = true,
                OrderStatus = Constans.OrderStatus_Retrieved,
                PaymentStatus = Constans.PaymentStatus_Approved,
                TicketSum = invoiceRequest.TicketSum,
                TotalSum = invoiceRequest.TotalSum,
                PaymentMethodId = invoiceRequest.PaymentMethodId,
                Tickets = tickets
            };

            _context.UpdateRange(screeningSeats);
            await _context.AddRangeAsync(tickets);
            await _context.AddAsync(invoice);

            await _context.SaveChangesAsync();

            return true;
        }
    }
}
