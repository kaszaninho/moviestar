using DatabaseAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PortalWWW.Controllers.Components
{
    public class ContactInformationComponent : ViewComponent
    {
        private readonly DatabaseAPIContext context;

        public ContactInformationComponent(DatabaseAPIContext context)
        {
            this.context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("ContactInformationComponent", await context.ContactInformation.OrderBy(item => item.Position).ToListAsync());
        }
    }
}
