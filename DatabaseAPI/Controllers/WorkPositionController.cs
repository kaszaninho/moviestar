using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DatabaseAPI.Data;
using DatabaseAPI.Models.General.DictionaryModels;

namespace DatabaseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkPositionController : ControllerBase
    {
        private readonly DatabaseAPIContext _context;

        public WorkPositionController(DatabaseAPIContext context)
        {
            _context = context;
        }

        // GET: api/WorkPosition
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WorkPosition>>> GetWorkPosition()
        {
            return await _context.WorkPosition.ToListAsync();
        }

        // GET: api/WorkPosition/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WorkPosition>> GetWorkPosition(int id)
        {
            var workPosition = await _context.WorkPosition.FindAsync(id);

            if (workPosition == null)
            {
                return NotFound();
            }

            return workPosition;
        }

        // PUT: api/WorkPosition/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWorkPosition(int id, WorkPosition workPosition)
        {
            if (id != workPosition.Id)
            {
                return BadRequest();
            }

            _context.Entry(workPosition).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WorkPositionExists(id))
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

        // POST: api/WorkPosition
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WorkPosition>> PostWorkPosition(WorkPosition workPosition)
        {
            _context.WorkPosition.Add(workPosition);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWorkPosition", new { id = workPosition.Id }, workPosition);
        }

        // DELETE: api/WorkPosition/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWorkPosition(int id)
        {
            var workPosition = await _context.WorkPosition.FindAsync(id);
            if (workPosition == null)
            {
                return NotFound();
            }

            _context.WorkPosition.Remove(workPosition);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WorkPositionExists(int id)
        {
            return _context.WorkPosition.Any(e => e.Id == id);
        }
    }
}
