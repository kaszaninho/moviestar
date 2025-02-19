using DatabaseAPI.Data;
using DatabaseAPI.Models.CMS;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatabaseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebsiteController : ControllerBase
    {
        private readonly DatabaseAPIContext _context;

        public WebsiteController(DatabaseAPIContext context)
        {
            _context = context;
        }

        // GET: api/Website
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Website>>> GetWebsiteList()
        {
            return await _context.Website.ToListAsync();
        }
    }
}
