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

        // PUT: api/Screening/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutScreening(int id, Screening screening)
        {
            if (id != screening.Id)
            {
                return BadRequest();
            }

            _context.Entry(screening).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ScreeningExists(id))
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

        // POST: api/Screening
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Screening>> PostScreening(Screening screening)
        {
            _context.Screening.Add(screening);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetScreening", new { id = screening.Id }, screening);
        }

        // DELETE: api/Screening/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteScreening(int id)
        {
            var screening = await _context.Screening.FindAsync(id);
            if (screening == null)
            {
                return NotFound();
            }

            _context.Screening.Remove(screening);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ScreeningExists(int id)
        {
            return _context.Screening.Any(e => e.Id == id);
        }
    }
}
