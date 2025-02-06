using DatabaseAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServiceStack;

namespace PortalWWW.Controllers.Components
{
    public class NavbarComponent : ViewComponent
    {
        private readonly DatabaseAPIContext context;
        public NavbarComponent(DatabaseAPIContext context)
        {
            this.context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("NavbarComponent", await context.Navbar.OrderBy(item => item.Position).ToListAsync());
        }
    }
}
