using DatabaseAPI.Data;
using DatabaseAPI.Models.CinemaMovie;
using DatabaseAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatabaseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScreeningController : ControllerBase
    {
        private readonly DatabaseAPIContext _context;

        public ScreeningController(DatabaseAPIContext context)
        {
            _context = context;
        }

        // GET: api/Screening/allscreenings/5
        [HttpGet("/allscreenings/{userId}")]
        public async Task<IEnumerable<ScreeningViewModel>> GetMoviesBasedOnScreenings(string userId)
        {
            IEnumerable<Screening?> screenings = await GatherMoviesBasedOnUser(userId);
            return screenings.Select(scr => new ScreeningViewModel
            {
                EndDate = scr.EndDate,
                StartDate = scr.StartDate,
                imageUrl = scr.Movie.imageUrl,
                MovieId = scr.MovieId,
                MovieTitle = scr.Movie.Name
            }).ToList();
        }

        private async Task<IEnumerable<Screening?>> GatherMoviesBasedOnUser(string userId)
        {
            var invList = await _context.Invoice.Include(inv => inv.Tickets).ThenInclude(inv => inv.ScreeningSeat).ThenInclude(inv => inv.Screening).ThenInclude(inv => inv.Movie).Where(inv => inv.UserId == userId).ToListAsync();
            var screenings = invList
                    .SelectMany(inv => inv.Tickets) // Flatten the tickets from all invoices
                    .Select(tick => tick.ScreeningSeat.Screening).DistinctBy(scr => scr.Id).ToList();
            return screenings;
        }

        // GET: api/Screening
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Screening>>> GetScreening()
        {
            return await _context.Screening.ToListAsync();
        }

        // GET: api/Screening/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Screening>> GetScreening(int id)
        {
            var screening = await _context.Screening.FindAsync(id);

            if (screening == null)
            {
                return NotFound();
            }

            return screening;
        }
    }
}
