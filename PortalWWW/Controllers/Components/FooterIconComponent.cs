using DatabaseAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PortalWWW.Controllers.Components
{
    public class FooterIconComponent : ViewComponent
    {
        private readonly DatabaseAPIContext context;
        public FooterIconComponent(DatabaseAPIContext context)
        {
            this.context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("FooterIconComponent", await context.FooterIcon.OrderBy(item => item.Position).ToListAsync());
        }
    }
}
