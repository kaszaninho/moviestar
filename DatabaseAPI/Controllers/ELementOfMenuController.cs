using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DatabaseAPI.Data;
using DatabaseAPI.Models.CoffeeShop;

namespace DatabaseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ELementOfMenuController : ControllerBase
    {
        private readonly DatabaseAPIContext _context;

        public ELementOfMenuController(DatabaseAPIContext context)
        {
            _context = context;
        }

        // GET: api/ELementOfMenu
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ELementOfMenu>>> GetELementOfMenu()
        {
            return await _context.ELementOfMenu.ToListAsync();
        }

        // GET: api/ELementOfMenu/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ELementOfMenu>> GetELementOfMenu(int id)
        {
            var eLementOfMenu = await _context.ELementOfMenu.FindAsync(id);

            if (eLementOfMenu == null)
            {
                return NotFound();
            }

            return eLementOfMenu;
        }

        // PUT: api/ELementOfMenu/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutELementOfMenu(int id, ELementOfMenu eLementOfMenu)
        {
            if (id != eLementOfMenu.Id)
            {
                return BadRequest();
            }

            _context.Entry(eLementOfMenu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ELementOfMenuExists(id))
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

        // POST: api/ELementOfMenu
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ELementOfMenu>> PostELementOfMenu(ELementOfMenu eLementOfMenu)
        {
            _context.ELementOfMenu.Add(eLementOfMenu);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetELementOfMenu", new { id = eLementOfMenu.Id }, eLementOfMenu);
        }

        // DELETE: api/ELementOfMenu/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteELementOfMenu(int id)
        {
            var eLementOfMenu = await _context.ELementOfMenu.FindAsync(id);
            if (eLementOfMenu == null)
            {
                return NotFound();
            }

            _context.ELementOfMenu.Remove(eLementOfMenu);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ELementOfMenuExists(int id)
        {
            return _context.ELementOfMenu.Any(e => e.Id == id);
        }
    }
}
