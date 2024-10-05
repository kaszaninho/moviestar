using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DatabaseAPI.Data;
using DatabaseAPI.Models.CinemaMovie.DictionaryModels;

namespace DatabaseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieProductionCompanyController : ControllerBase
    {
        private readonly DatabaseAPIContext _context;

        public MovieProductionCompanyController(DatabaseAPIContext context)
        {
            _context = context;
        }

        // GET: api/MovieProductionCompany
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MovieProductionCompany>>> GetMovieProductionCompany()
        {
            return await _context.MovieProductionCompany.ToListAsync();
        }

        // GET: api/MovieProductionCompany/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MovieProductionCompany>> GetMovieProductionCompany(int id)
        {
            var movieProductionCompany = await _context.MovieProductionCompany.FindAsync(id);

            if (movieProductionCompany == null)
            {
                return NotFound();
            }

            return movieProductionCompany;
        }

        // PUT: api/MovieProductionCompany/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovieProductionCompany(int id, MovieProductionCompany movieProductionCompany)
        {
            if (id != movieProductionCompany.Id)
            {
                return BadRequest();
            }

            _context.Entry(movieProductionCompany).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieProductionCompanyExists(id))
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

        // POST: api/MovieProductionCompany
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MovieProductionCompany>> PostMovieProductionCompany(MovieProductionCompany movieProductionCompany)
        {
            _context.MovieProductionCompany.Add(movieProductionCompany);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovieProductionCompany", new { id = movieProductionCompany.Id }, movieProductionCompany);
        }

        // DELETE: api/MovieProductionCompany/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovieProductionCompany(int id)
        {
            var movieProductionCompany = await _context.MovieProductionCompany.FindAsync(id);
            if (movieProductionCompany == null)
            {
                return NotFound();
            }

            _context.MovieProductionCompany.Remove(movieProductionCompany);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MovieProductionCompanyExists(int id)
        {
            return _context.MovieProductionCompany.Any(e => e.Id == id);
        }
    }
}
