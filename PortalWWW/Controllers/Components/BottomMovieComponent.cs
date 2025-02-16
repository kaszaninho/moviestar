using DatabaseAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace PortalWWW.Controllers.Components
{
    public class BottomMovieComponent : ViewComponent
    {
        private readonly DatabaseAPIContext context;
        public BottomMovieComponent(DatabaseAPIContext context)
        {
            this.context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("BottomMovieComponent");
        }
    }
}
