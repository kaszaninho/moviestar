using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DatabaseAPI.Data;
using DatabaseAPI.Models.General;
using DatabaseAPI.Models.CMS;

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
