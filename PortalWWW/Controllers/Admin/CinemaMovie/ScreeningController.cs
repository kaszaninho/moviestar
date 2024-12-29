using DatabaseAPI.Models.CinemaMovie;
using DatabaseAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace PortalWWW.Controllers.Admin.CinemaMovie
{
    public class ScreeningController : BaseDictionaryController<Screening>
    {
        public ScreeningController(IRepository<Screening> repository) : base(repository)
        {
        }

        override public async Task<IActionResult> Create(Screening entity)
        {
            var movie = await repository.GetDbSet<Movie>().Where(x => x.Id == entity.MovieId)
                .FirstAsync();
            var screen = await repository.GetDbSet<Screen>().Where(x => x.Id == entity.ScreenId)
                .Include(x => x.Seats)
                .FirstAsync();
            entity.EndDate = entity.StartDate.Value.AddMinutes(movie.Duration.Value);
            List<ScreeningSeat> screeningSeats = new List<ScreeningSeat>();
            foreach (var item in screen.Seats)
            {
                screeningSeats.Add(new ScreeningSeat
                {
                    IsTaken = false,
                    IsActive = true,
                    Screening = entity,
                    Seat = item,
                    Name = item.Name
                });
            }
            entity.ScreeningSeats = screeningSeats;
            return await base.Create(entity);
        }
        override public async Task<IActionResult> Index()
        {
            var entities = await repository.getDbSet()
                .Include(screening => screening.Movie)
                .Include(screening => screening.Screen)
                .ToListAsync();
            ViewData["type"] = typeof(Screening);
            return View(entities);
        }

        override public async Task<IActionResult> Create()
        {
            ViewBag.Movie = new SelectList(await repository.GetDbSet<Movie>().ToListAsync(), "Id", "Name");
            ViewBag.Screen = new SelectList(await repository.GetDbSet<Screen>().ToListAsync(), "Id", "Name");
            ViewData["type"] = typeof(Screening);
            ViewData["PartialViewName"] = "ScreeningCreate";
            return View();
        }

        override public async Task<IActionResult> Edit(int id)
        {
            var entity = await repository.FindEntityAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            ViewBag.Movie = new SelectList(await repository.GetDbSet<Movie>().ToListAsync(), "Id", "Name");
            ViewBag.Screen = new SelectList(await repository.GetDbSet<Screen>().ToListAsync(), "Id", "Name");
            ViewData["type"] = typeof(Screening);
            ViewData["PartialViewName"] = "ScreeningCreate";
            return View(entity);
        }

        override public async Task<IActionResult> Details(int id)
        {
            var entity = await repository.getDbSet()
                .Include(screening => screening.Movie)
                .Include(screening => screening.Screen)
                .FirstAsync(screening => screening.Id == id);
            if (entity == null)
            {
                return NotFound();
            }
            ViewData["type"] = typeof(Screening);
            ViewData["PartialViewName"] = "ScreeningDetails";
            return View(entity);
        }

        override public async Task<IActionResult> Delete(int id)
        {
            var entity = await repository.getDbSet()
                .Include(screening => screening.Movie)
                .Include(screening => screening.Screen)
                .FirstAsync(screening => screening.Id == id);
            if (entity == null)
            {
                return NotFound();
            }
            ViewData["type"] = typeof(Screening);
            ViewData["PartialViewName"] = "ScreeningDetails";
            return View(entity);
        }
    }
}
