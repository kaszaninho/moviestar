using DatabaseAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PortalWWW.Controllers.Components
{
    public class WebsiteComponent : ViewComponent
    {
        private readonly DatabaseAPIContext context;

        public WebsiteComponent(DatabaseAPIContext context)
        {
            this.context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("WebsiteComponent", await context.Website.ToListAsync());
        }
    }
}
