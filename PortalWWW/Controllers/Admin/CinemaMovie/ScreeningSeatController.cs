using DatabaseAPI.Models.CinemaMovie;
using DatabaseAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace PortalWWW.Controllers.Admin.CinemaMovie
{
    public class ScreeningSeatController : BaseDictionaryController<ScreeningSeat>
    {
        public ScreeningSeatController(IRepository<ScreeningSeat> repository) : base(repository)
        { }
        override public async Task<IActionResult> Index()
        {
            var entities = await repository.getDbSet()
                .Include(screeningSeat => screeningSeat.Screening)
                .ThenInclude(screening =>  screening.Movie)
                .ToListAsync();
            ViewData["type"] = typeof(ScreeningSeat);
            return View(entities);
        }

        override public async Task<IActionResult> Create()
        {
            ViewBag.Screening = new SelectList(await repository.GetDbSet<Screening>().ToListAsync(), "Id", "Name");
            ViewData["type"] = typeof(ScreeningSeat);
            ViewData["PartialViewName"] = "ScreeningSeatCreate";
            return View();
        }

        override public async Task<IActionResult> Edit(int id)
        {
            var entity = await repository.FindEntityAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            ViewBag.Screening = new SelectList(await repository.GetDbSet<Screening>().ToListAsync(), "Id", "Name");
            ViewData["type"] = typeof(ScreeningSeat);
            ViewData["PartialViewName"] = "ScreeningSeatCreate";
            return View(entity);
        }

        override public async Task<IActionResult> Details(int id)
        {
            var entity = await repository.getDbSet()
                .Include(screeningSeat => screeningSeat.Screening)
                .FirstAsync(screeningSeat => screeningSeat.Id == id);
            if (entity == null)
            {
                return NotFound();
            }
            ViewData["type"] = typeof(ScreeningSeat);
            ViewData["PartialViewName"] = "ScreeningSeatDetails";
            return View(entity);
        }

        override public async Task<IActionResult> Delete(int id)
        {
            var entity = await repository.getDbSet()
                .Include(screeningSeat => screeningSeat.Screening)
                .FirstAsync(screeningSeat => screeningSeat.Id == id);
            if (entity == null)
            {
                return NotFound();
            }
            ViewData["type"] = typeof(ScreeningSeat);
            ViewData["PartialViewName"] = "ScreeningSeatDetails";
            return View(entity);
        }
    }
}
