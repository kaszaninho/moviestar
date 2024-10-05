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
    public class MovieFormatController : ControllerBase
    {
        private readonly DatabaseAPIContext _context;

        public MovieFormatController(DatabaseAPIContext context)
        {
            _context = context;
        }

        // GET: api/MovieFormat
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MovieFormat>>> GetMovieFormat()
        {
            return await _context.MovieFormat.ToListAsync();
        }

        // GET: api/MovieFormat/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MovieFormat>> GetMovieFormat(int id)
        {
            var movieFormat = await _context.MovieFormat.FindAsync(id);

            if (movieFormat == null)
            {
                return NotFound();
            }

            return movieFormat;
        }

        // PUT: api/MovieFormat/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovieFormat(int id, MovieFormat movieFormat)
        {
            if (id != movieFormat.Id)
            {
                return BadRequest();
            }

            _context.Entry(movieFormat).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieFormatExists(id))
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

        // POST: api/MovieFormat
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MovieFormat>> PostMovieFormat(MovieFormat movieFormat)
        {
            _context.MovieFormat.Add(movieFormat);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovieFormat", new { id = movieFormat.Id }, movieFormat);
        }

        // DELETE: api/MovieFormat/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovieFormat(int id)
        {
            var movieFormat = await _context.MovieFormat.FindAsync(id);
            if (movieFormat == null)
            {
                return NotFound();
            }

            _context.MovieFormat.Remove(movieFormat);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MovieFormatExists(int id)
        {
            return _context.MovieFormat.Any(e => e.Id == id);
        }
    }
}
