using DatabaseAPI.Data;
using DatabaseAPI.Models.Shop;
using Microsoft.AspNetCore.Mvc;

namespace PortalWWW.Controllers.Components
{
	public class CustomerQueryComponent : ViewComponent
	{
		private readonly DatabaseAPIContext _context;
		public CustomerQueryComponent(DatabaseAPIContext context)
		{
			_context = context;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			return View("CustomerQueryComponent", new CustomerQuery());
		}
	}
}