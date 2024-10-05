using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DatabaseAPI.Data;
using DatabaseAPI.Models.CoffeeShop.DictionaryModels;

namespace DatabaseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeOfElementOfMenuController : ControllerBase
    {
        private readonly DatabaseAPIContext _context;

        public TypeOfElementOfMenuController(DatabaseAPIContext context)
        {
            _context = context;
        }

        // GET: api/TypeOfElementOfMenu
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TypeOfElementOfMenu>>> GetTypeOfElementOfMenu()
        {
            return await _context.TypeOfElementOfMenu.ToListAsync();
        }

        // GET: api/TypeOfElementOfMenu/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TypeOfElementOfMenu>> GetTypeOfElementOfMenu(int id)
        {
            var typeOfElementOfMenu = await _context.TypeOfElementOfMenu.FindAsync(id);

            if (typeOfElementOfMenu == null)
            {
                return NotFound();
            }

            return typeOfElementOfMenu;
        }

        // PUT: api/TypeOfElementOfMenu/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTypeOfElementOfMenu(int id, TypeOfElementOfMenu typeOfElementOfMenu)
        {
            if (id != typeOfElementOfMenu.Id)
            {
                return BadRequest();
            }

            _context.Entry(typeOfElementOfMenu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypeOfElementOfMenuExists(id))
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

        // POST: api/TypeOfElementOfMenu
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TypeOfElementOfMenu>> PostTypeOfElementOfMenu(TypeOfElementOfMenu typeOfElementOfMenu)
        {
            _context.TypeOfElementOfMenu.Add(typeOfElementOfMenu);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTypeOfElementOfMenu", new { id = typeOfElementOfMenu.Id }, typeOfElementOfMenu);
        }

        // DELETE: api/TypeOfElementOfMenu/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTypeOfElementOfMenu(int id)
        {
            var typeOfElementOfMenu = await _context.TypeOfElementOfMenu.FindAsync(id);
            if (typeOfElementOfMenu == null)
            {
                return NotFound();
            }

            _context.TypeOfElementOfMenu.Remove(typeOfElementOfMenu);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TypeOfElementOfMenuExists(int id)
        {
            return _context.TypeOfElementOfMenu.Any(e => e.Id == id);
        }
    }
}
