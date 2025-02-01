using DatabaseAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PortalWWW.Controllers.Components
{
    public class NewsletterComponent : ViewComponent
    {
        private readonly DatabaseAPIContext context;
        public NewsletterComponent(DatabaseAPIContext context)
        {
            this.context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("NewsletterComponent", await context.Newsletter.OrderBy(item => item.Position).ToListAsync());
        }
    }
}
