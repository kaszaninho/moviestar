using DatabaseAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace PortalWWW.Controllers.Components
{
    public class FooterComponent : ViewComponent

    {
        private readonly DatabaseAPIContext dbContext;
        public FooterComponent(DatabaseAPIContext context)
        {
            dbContext = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("FooterComponent");
        }
    }
}
