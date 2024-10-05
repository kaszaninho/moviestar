using DatabaseAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PortalWWW.Controllers.Admin
{
    public class AdminController : Controller
    {
        private readonly DatabaseAPIContext dbContext;

        public AdminController(DatabaseAPIContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
