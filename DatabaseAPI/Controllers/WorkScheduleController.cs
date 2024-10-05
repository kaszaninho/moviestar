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
    public class WorkScheduleController : ControllerBase
    {
        private readonly DatabaseAPIContext _context;

        public WorkScheduleController(DatabaseAPIContext context)
        {
            _context = context;
        }

        // GET: api/WorkSchedule
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WorkSchedule>>> GetWorkSchedule()
        {
            return await _context.WorkSchedule.ToListAsync();
        }

        // GET: api/WorkSchedule/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WorkSchedule>> GetWorkSchedule(int id)
        {
            var workSchedule = await _context.WorkSchedule.FindAsync(id);

            if (workSchedule == null)
            {
                return NotFound();
            }

            return workSchedule;
        }

        // PUT: api/WorkSchedule/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWorkSchedule(int id, WorkSchedule workSchedule)
        {
            if (id != workSchedule.Id)
            {
                return BadRequest();
            }

            _context.Entry(workSchedule).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WorkScheduleExists(id))
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

        // POST: api/WorkSchedule
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WorkSchedule>> PostWorkSchedule(WorkSchedule workSchedule)
        {
            _context.WorkSchedule.Add(workSchedule);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWorkSchedule", new { id = workSchedule.Id }, workSchedule);
        }

        // DELETE: api/WorkSchedule/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWorkSchedule(int id)
        {
            var workSchedule = await _context.WorkSchedule.FindAsync(id);
            if (workSchedule == null)
            {
                return NotFound();
            }

            _context.WorkSchedule.Remove(workSchedule);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WorkScheduleExists(int id)
        {
            return _context.WorkSchedule.Any(e => e.Id == id);
        }
    }
}
