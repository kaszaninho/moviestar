using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DatabaseAPI.Data;
using DatabaseAPI.Models.General;

namespace DatabaseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpeningHourController : ControllerBase
    {
        private readonly DatabaseAPIContext _context;

        public OpeningHourController(DatabaseAPIContext context)
        {
            _context = context;
        }

        // GET: api/OpeningHour
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OpeningHour>>> GetOpeningHour()
        {
            return await _context.OpeningHour.ToListAsync();
        }

        // GET: api/OpeningHour/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OpeningHour>> GetOpeningHour(int id)
        {
            var openingHour = await _context.OpeningHour.FindAsync(id);

            if (openingHour == null)
            {
                return NotFound();
            }

            return openingHour;
        }

        // PUT: api/OpeningHour/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOpeningHour(int id, OpeningHour openingHour)
        {
            if (id != openingHour.Id)
            {
                return BadRequest();
            }

            _context.Entry(openingHour).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OpeningHourExists(id))
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

        // POST: api/OpeningHour
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OpeningHour>> PostOpeningHour(OpeningHour openingHour)
        {
            _context.OpeningHour.Add(openingHour);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOpeningHour", new { id = openingHour.Id }, openingHour);
        }

        // DELETE: api/OpeningHour/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOpeningHour(int id)
        {
            var openingHour = await _context.OpeningHour.FindAsync(id);
            if (openingHour == null)
            {
                return NotFound();
            }

            _context.OpeningHour.Remove(openingHour);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OpeningHourExists(int id)
        {
            return _context.OpeningHour.Any(e => e.Id == id);
        }
    }
}
