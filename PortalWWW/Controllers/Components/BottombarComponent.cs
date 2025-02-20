using DatabaseAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PortalWWW.Controllers.Components
{
    public class BottombarComponent : ViewComponent
    {
        private readonly DatabaseAPIContext context;

        public BottombarComponent(DatabaseAPIContext context)
        {
            this.context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("BottombarComponent", await context.Bottombar.OrderBy(item => item.Position).ToListAsync());
        }
    }
}
