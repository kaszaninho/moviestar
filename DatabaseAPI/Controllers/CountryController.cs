using DatabaseAPI.Data;
using DatabaseAPI.Models.DictionaryModels;
using DatabaseAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatabaseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly DatabaseAPIContext _context;

        public CountryController(DatabaseAPIContext context)
        {
            _context = context;
        }

        // GET: api/Country
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CountryViewModel>>> GetCountry()
        {
            return await _context.Country.Select(x => new CountryViewModel
            {
                CountryName = x.Name,
                CountryId = x.Id
            }).ToListAsync();
        }

        // GET: api/Country/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Country>> GetCountry(int id)
        {
            var country = await _context.Country.FindAsync(id);

            if (country == null)
            {
                return NotFound();
            }

            return country;
        }
    }
}
