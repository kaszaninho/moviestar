using DatabaseAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PortalWWW.Controllers.Components
{
    public class OpeningHourComponent : ViewComponent
    {
        private readonly DatabaseAPIContext context;
        public OpeningHourComponent(DatabaseAPIContext context)
        {
            this.context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("OpeningHourComponent", await context.OpeningHour.ToListAsync());
        }
    }
}
