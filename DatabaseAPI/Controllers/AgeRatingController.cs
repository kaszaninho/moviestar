using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DatabaseAPI.Data;
using DatabaseAPI.Models.DictionaryModels;

namespace DatabaseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgeRatingController : ControllerBase
    {
        private readonly DatabaseAPIContext _context;

        public AgeRatingController(DatabaseAPIContext context)
        {
            _context = context;
        }

        // GET: api/AgeRating
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AgeRating>>> GetAgeRating()
        {
            return await _context.AgeRating.ToListAsync();
        }

        // GET: api/AgeRating/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AgeRating>> GetAgeRating(int id)
        {
            var ageRating = await _context.AgeRating.FindAsync(id);

            if (ageRating == null)
            {
                return NotFound();
            }

            return ageRating;
        }

        // PUT: api/AgeRating/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAgeRating(int id, AgeRating ageRating)
        {
            if (id != ageRating.Id)
            {
                return BadRequest();
            }

            _context.Entry(ageRating).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AgeRatingExists(id))
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

        // POST: api/AgeRating
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AgeRating>> PostAgeRating(AgeRating ageRating)
        {
            _context.AgeRating.Add(ageRating);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAgeRating", new { id = ageRating.Id }, ageRating);
        }

        // DELETE: api/AgeRating/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAgeRating(int id)
        {
            var ageRating = await _context.AgeRating.FindAsync(id);
            if (ageRating == null)
            {
                return NotFound();
            }

            _context.AgeRating.Remove(ageRating);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AgeRatingExists(int id)
        {
            return _context.AgeRating.Any(e => e.Id == id);
        }
    }
}
