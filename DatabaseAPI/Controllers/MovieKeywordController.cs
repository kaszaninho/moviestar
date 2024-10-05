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
    public class MovieKeywordController : ControllerBase
    {
        private readonly DatabaseAPIContext _context;

        public MovieKeywordController(DatabaseAPIContext context)
        {
            _context = context;
        }

        // GET: api/MovieKeyword
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MovieKeywords>>> GetMovieKeywords()
        {
            return await _context.MovieKeywords.ToListAsync();
        }

        // GET: api/MovieKeyword/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MovieKeywords>> GetMovieKeywords(int id)
        {
            var movieKeywords = await _context.MovieKeywords.FindAsync(id);

            if (movieKeywords == null)
            {
                return NotFound();
            }

            return movieKeywords;
        }

        // PUT: api/MovieKeyword/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovieKeywords(int id, MovieKeywords movieKeywords)
        {
            if (id != movieKeywords.Id)
            {
                return BadRequest();
            }

            _context.Entry(movieKeywords).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieKeywordsExists(id))
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

        // POST: api/MovieKeyword
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MovieKeywords>> PostMovieKeywords(MovieKeywords movieKeywords)
        {
            _context.MovieKeywords.Add(movieKeywords);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovieKeywords", new { id = movieKeywords.Id }, movieKeywords);
        }

        // DELETE: api/MovieKeyword/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovieKeywords(int id)
        {
            var movieKeywords = await _context.MovieKeywords.FindAsync(id);
            if (movieKeywords == null)
            {
                return NotFound();
            }

            _context.MovieKeywords.Remove(movieKeywords);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MovieKeywordsExists(int id)
        {
            return _context.MovieKeywords.Any(e => e.Id == id);
        }
    }
}
