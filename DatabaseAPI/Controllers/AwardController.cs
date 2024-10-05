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
    public class AwardController : ControllerBase
    {
        private readonly DatabaseAPIContext _context;

        public AwardController(DatabaseAPIContext context)
        {
            _context = context;
        }

        // GET: api/Award
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Award>>> GetAward()
        {
            return await _context.Award.ToListAsync();
        }

        // GET: api/Award/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Award>> GetAward(int id)
        {
            var award = await _context.Award.FindAsync(id);

            if (award == null)
            {
                return NotFound();
            }

            return award;
        }

        // PUT: api/Award/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAward(int id, Award award)
        {
            if (id != award.Id)
            {
                return BadRequest();
            }

            _context.Entry(award).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AwardExists(id))
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

        // POST: api/Award
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Award>> PostAward(Award award)
        {
            _context.Award.Add(award);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAward", new { id = award.Id }, award);
        }

        // DELETE: api/Award/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAward(int id)
        {
            var award = await _context.Award.FindAsync(id);
            if (award == null)
            {
                return NotFound();
            }

            _context.Award.Remove(award);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AwardExists(int id)
        {
            return _context.Award.Any(e => e.Id == id);
        }
    }
}
