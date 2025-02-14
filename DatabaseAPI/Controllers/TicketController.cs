using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DatabaseAPI.Data;
using DatabaseAPI.Models.CinemaMovie;
using DatabaseAPI.ViewModels;

namespace DatabaseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly DatabaseAPIContext _context;

        public TicketController(DatabaseAPIContext context)
        {
            _context = context;
        }

        // GET: api/Ticket
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ticket>>> GetTicket()
        {
            return await _context.Ticket.ToListAsync();
        }

        // GET: api/Ticket
        [HttpGet("ticketsforuser/{userId}")]
        public async Task<ActionResult<IEnumerable<TicketViewModel>>> GetTicketsForUser(string userId)
        {
            var tickets = await _context.Ticket.Include(ticket => ticket.ScreeningSeat).ThenInclude(ticket => ticket.Screening).ThenInclude(ticket => ticket.Movie)
                .Include(ticket => ticket.Invoice).Where(ticket => ticket.Invoice.UserId == userId).ToListAsync();
            return tickets.Select(ticket => new TicketViewModel
            {
                StartDate = ticket.ScreeningSeat.Screening.StartDate,
                EndDate = ticket.ScreeningSeat.Screening.EndDate,
                MovieId = ticket.ScreeningSeat.Screening.MovieId,
                MovieName = ticket.ScreeningSeat.Screening.Movie.Name,
                SeatNumber = ticket.ScreeningSeat.Name,
                TicketPrice = ticket.ScreeningSeat.Screening.Movie.TicketPrice,
                TicketId = ticket.Id
            }).ToList();
        }

        // GET: api/Ticket/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ticket>> GetTicket(int id)
        {
            var ticket = await _context.Ticket.FindAsync(id);

            if (ticket == null)
            {
                return NotFound();
            }

            return ticket;
        }

        // PUT: api/Ticket/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTicket(int id, Ticket ticket)
        {
            if (id != ticket.Id)
            {
                return BadRequest();
            }

            _context.Entry(ticket).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TicketExists(id))
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

        // POST: api/Ticket
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Ticket>> PostTicket(Ticket ticket)
        {
            _context.Ticket.Add(ticket);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTicket", new { id = ticket.Id }, ticket);
        }

        // DELETE: api/Ticket/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTicket(int id)
        {
            var ticket = await _context.Ticket.FindAsync(id);
            if (ticket == null)
            {
                return NotFound();
            }

            _context.Ticket.Remove(ticket);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TicketExists(int id)
        {
            return _context.Ticket.Any(e => e.Id == id);
        }
    }
}
