using DatabaseAPI.Data;
using DatabaseAPI.Models.CinemaMovie;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PortalWWW.Controllers.Components
{
    public class NavigationComponent : ViewComponent
    {
        private readonly DatabaseAPIContext dbContext;
        public NavigationComponent(DatabaseAPIContext context)
        {
            dbContext = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("NavigationComponent");
        }
    }
}
