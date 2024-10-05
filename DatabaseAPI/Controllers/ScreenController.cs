using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DatabaseAPI.Data;
using DatabaseAPI.Models.CinemaMovie;

namespace DatabaseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScreenController : ControllerBase
    {
        private readonly DatabaseAPIContext _context;

        public ScreenController(DatabaseAPIContext context)
        {
            _context = context;
        }

        // GET: api/Screen
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Screen>>> GetScreen()
        {
            return await _context.Screen.ToListAsync();
        }

        // GET: api/Screen/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Screen>> GetScreen(int id)
        {
            var screen = await _context.Screen.FindAsync(id);

            if (screen == null)
            {
                return NotFound();
            }

            return screen;
        }

        // PUT: api/Screen/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutScreen(int id, Screen screen)
        {
            if (id != screen.Id)
            {
                return BadRequest();
            }

            _context.Entry(screen).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ScreenExists(id))
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

        // POST: api/Screen
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Screen>> PostScreen(Screen screen)
        {
            _context.Screen.Add(screen);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetScreen", new { id = screen.Id }, screen);
        }

        // DELETE: api/Screen/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteScreen(int id)
        {
            var screen = await _context.Screen.FindAsync(id);
            if (screen == null)
            {
                return NotFound();
            }

            _context.Screen.Remove(screen);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ScreenExists(int id)
        {
            return _context.Screen.Any(e => e.Id == id);
        }
    }
}
