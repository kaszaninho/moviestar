using DatabaseAPI.Data;
using DatabaseAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatabaseAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ScreeningSeatController : ControllerBase
    {
        private readonly DatabaseAPIContext _context;

        public ScreeningSeatController(DatabaseAPIContext context)
        {
            _context = context;
        }

        [HttpGet("getseatsforscreening/{screeningId}")]
        public async Task<IEnumerable<ScreeningSeatViewModel>> GetSeatsForScreening(int screeningId)
        {
            return await _context.ScreeningSeat
                .Include(x => x.Screening)
                .ThenInclude(x => x.Movie)
                .Where(x => x.ScreeningId == screeningId).Select(x => new ScreeningSeatViewModel
                {
                    ScreeningId = screeningId,
                    IsTaken = x.IsTaken,
                    ScreeningSeatId = x.Id,
                    SeatNumber = x.Name,
                    TicketPrice = x.Screening.Movie.TicketPrice
                }).ToListAsync();
        }
    }
}