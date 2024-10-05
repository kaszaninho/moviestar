//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using DatabaseAPI.Data;
//using DatabaseAPI.Models.People;

//namespace DatabaseAPI.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ClientLevelController : ControllerBase
//    {
//        private readonly DatabaseAPIContext _context;

//        public ClientLevelController(DatabaseAPIContext context)
//        {
//            _context = context;
//        }

//        // GET: api/ClientLevel
//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<ClientLevel>>> GetClientLevel()
//        {
//            return await _context.ClientLevel.ToListAsync();
//        }

//        // GET: api/ClientLevel/5
//        [HttpGet("{id}")]
//        public async Task<ActionResult<ClientLevel>> GetClientLevel(int id)
//        {
//            var clientLevel = await _context.ClientLevel.FindAsync(id);

//            if (clientLevel == null)
//            {
//                return NotFound();
//            }

//            return clientLevel;
//        }

//        // PUT: api/ClientLevel/5
//        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
//        [HttpPut("{id}")]
//        public async Task<IActionResult> PutClientLevel(int id, ClientLevel clientLevel)
//        {
//            if (id != clientLevel.Id)
//            {
//                return BadRequest();
//            }

//            _context.Entry(clientLevel).State = EntityState.Modified;

//            try
//            {
//                await _context.SaveChangesAsync();
//            }
//            catch (DbUpdateConcurrencyException)
//            {
//                if (!ClientLevelExists(id))
//                {
//                    return NotFound();
//                }
//                else
//                {
//                    throw;
//                }
//            }

//            return NoContent();
//        }

//        // POST: api/ClientLevel
//        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
//        [HttpPost]
//        public async Task<ActionResult<ClientLevel>> PostClientLevel(ClientLevel clientLevel)
//        {
//            _context.ClientLevel.Add(clientLevel);
//            await _context.SaveChangesAsync();

//            return CreatedAtAction("GetClientLevel", new { id = clientLevel.Id }, clientLevel);
//        }

//        // DELETE: api/ClientLevel/5
//        [HttpDelete("{id}")]
//        public async Task<IActionResult> DeleteClientLevel(int id)
//        {
//            var clientLevel = await _context.ClientLevel.FindAsync(id);
//            if (clientLevel == null)
//            {
//                return NotFound();
//            }

//            _context.ClientLevel.Remove(clientLevel);
//            await _context.SaveChangesAsync();

//            return NoContent();
//        }

//        private bool ClientLevelExists(int id)
//        {
//            return _context.ClientLevel.Any(e => e.Id == id);
//        }
//    }
//}
