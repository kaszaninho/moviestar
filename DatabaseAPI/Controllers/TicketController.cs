using DatabaseAPI.Data;
using DatabaseAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
    }
}
