using DatabaseAPI.Models.CinemaMovie;
using DatabaseAPI.Models.DictionaryModels;
using DatabaseAPI.Models.General;
using DatabaseAPI.Models.General.DictionaryModels;
using DatabaseAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace PortalWWW.Controllers.Admin.General
{
    public class AddressController : BaseDictionaryController<Address>
    {
        public AddressController(IRepository<Address> repository) : base(repository)
    {
        }


        override public async Task<IActionResult> Index()
        {
            var entities = await repository.getDbSet()
                .Include(address => address.Country)
                .ToListAsync();
            ViewData["type"] = typeof(Address);
            return View(entities);
        }

        override public async Task<IActionResult> Create()
        {
            ViewBag.Country = new SelectList(await repository.GetDbSet<Country>().ToListAsync(), "Id", "Name");
            ViewData["type"] = typeof(Address);
            ViewData["PartialViewName"] = "AddressCreate";
            return View();
        }

        override public async Task<IActionResult> Edit(int id)
        {
            var entity = await repository.FindEntityAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            ViewBag.Country = new SelectList(await repository.GetDbSet<Country>().ToListAsync(), "Id", "Name");
            ViewData["type"] = typeof(Address);
            ViewData["PartialViewName"] = "AddressCreate";
            return View(entity);
        }

        override public async Task<IActionResult> Details(int id)
        {
            var entity = await repository.getDbSet()
                .Include(address => address.Country)
                .FirstAsync(address => address.Id == id);
            if (entity == null)
            {
                return NotFound();
            }
            ViewData["type"] = typeof(Address);
            ViewData["PartialViewName"] = "AddressDetails";
            return View(entity);
        }

        override public async Task<IActionResult> Delete(int id)
        {
            var entity = await repository.getDbSet()
                .Include(address => address.Country)
                .FirstAsync(address => address.Id == id);
            if (entity == null)
            {
                return NotFound();
            }
            ViewData["type"] = typeof(Address);
            ViewData["PartialViewName"] = "AddressDetails";
            return View(entity);
        }
    }
}
