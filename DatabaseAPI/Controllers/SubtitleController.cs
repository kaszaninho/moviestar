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
    public class SubtitleController : ControllerBase
    {
        private readonly DatabaseAPIContext _context;

        public SubtitleController(DatabaseAPIContext context)
        {
            _context = context;
        }

        // GET: api/Subtitle
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Subtitles>>> GetSubtitles()
        {
            return await _context.Subtitles.ToListAsync();
        }

        // GET: api/Subtitle/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Subtitles>> GetSubtitles(int id)
        {
            var subtitles = await _context.Subtitles.FindAsync(id);

            if (subtitles == null)
            {
                return NotFound();
            }

            return subtitles;
        }

        // PUT: api/Subtitle/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubtitles(int id, Subtitles subtitles)
        {
            if (id != subtitles.Id)
            {
                return BadRequest();
            }

            _context.Entry(subtitles).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubtitlesExists(id))
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

        // POST: api/Subtitle
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Subtitles>> PostSubtitles(Subtitles subtitles)
        {
            _context.Subtitles.Add(subtitles);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSubtitles", new { id = subtitles.Id }, subtitles);
        }

        // DELETE: api/Subtitle/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubtitles(int id)
        {
            var subtitles = await _context.Subtitles.FindAsync(id);
            if (subtitles == null)
            {
                return NotFound();
            }

            _context.Subtitles.Remove(subtitles);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SubtitlesExists(int id)
        {
            return _context.Subtitles.Any(e => e.Id == id);
        }
    }
}
