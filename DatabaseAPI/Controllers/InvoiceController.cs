using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DatabaseAPI.Data;
using DatabaseAPI.Models.General;
using DatabaseAPI.Models.People;
using DatabaseAPI.ViewModels;

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
                    Eircode = invoice.User.Address.EirCode
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

        // PUT: api/Invoice/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInvoice(int id, Invoice invoice)
        {
            if (id != invoice.Id)
            {
                return BadRequest();
            }

            _context.Entry(invoice).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InvoiceExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Invoice
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Invoice>> PostInvoice(Invoice invoice)
        {
            _context.Invoice.Add(invoice);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInvoice", new { id = invoice.Id }, invoice);
        }

        // DELETE: api/Invoice/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInvoice(int id)
        {
            var invoice = await _context.Invoice.FindAsync(id);
            if (invoice == null)
            {
                return NotFound();
            }

            _context.Invoice.Remove(invoice);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InvoiceExists(int id)
        {
            return _context.Invoice.Any(e => e.Id == id);
        }
    }
}
