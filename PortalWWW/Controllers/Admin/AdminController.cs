using DatabaseAPI.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PortalWWW.Controllers.Admin
{

    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly DatabaseAPIContext dbContext;

        public AdminController(DatabaseAPIContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
