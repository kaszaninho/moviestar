using DatabaseAPI.Models.CinemaMovie;
using DatabaseAPI.Models.DictionaryModels;
using DatabaseAPI.Models.People;
using DatabaseAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace PortalWWW.Controllers.Admin.People
{
    public class DirectorController : BaseDictionaryController<Director>
    {
        public DirectorController(IRepository<Director> repository) : base(repository)
        { }
        override public async Task<IActionResult> Index()
        {
            var entities = await repository.getDbSet()
                .ToListAsync();
            ViewData["type"] = typeof(Director);
            return View(entities);
        }

        override public async Task<IActionResult> Create()
        {
            ViewBag.Country = new SelectList(await repository.GetDbSet<Country>().ToListAsync(), "Id", "Name");
            ViewData["type"] = typeof(Director);
            ViewData["PartialViewName"] = "DirectorCreate";
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
            ViewData["type"] = typeof(Director);
            ViewData["PartialViewName"] = "DirectorCreate";
            return View(entity);
        }

        override public async Task<IActionResult> Details(int id)
        {
            var entity = await repository.getDbSet()
                .Include(x => x.Country)
                .FirstAsync(dire => dire.Id == id);
            if (entity == null)
            {
                return NotFound();
            }
            ViewData["type"] = typeof(Director);
            ViewData["PartialViewName"] = "DirectorDetails";
            return View(entity);
        }
    }
}
