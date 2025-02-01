using DatabaseAPI.Data;
using DatabaseAPI.Models.CinemaMovie;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PortalWWW.Controllers.MovieComponents
{
	public class AdminNavigationComponent : ViewComponent
	{
		private readonly DatabaseAPIContext dbContext;
		public AdminNavigationComponent(DatabaseAPIContext context)
		{
			dbContext = context;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			return View("AdminNavigationComponent");
		}
	}
}
