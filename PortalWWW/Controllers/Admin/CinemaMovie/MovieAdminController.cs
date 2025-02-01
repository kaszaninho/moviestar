using DatabaseAPI.Models.CinemaMovie;
using DatabaseAPI.Models.CinemaMovie.DictionaryModels;
using DatabaseAPI.Models.DictionaryModels;
using DatabaseAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ServiceStack;

namespace PortalWWW.Controllers.Admin.CinemaMovie
{
    public class MovieAdminController : BaseDictionaryController<Movie>
    {
        public MovieAdminController(IRepository<Movie> repository) : base(repository)
        {
        }

        override public async Task<IActionResult> Index()
        {
            ViewData["type"] = typeof(Movie);
            ViewData["entityEndpoint"] = "movieadmin";
            return View();
        }


        override public async Task<IActionResult> Create()
        {
            ViewBag.AgeRating = new SelectList(await repository.GetDbSet<AgeRating>().ToListAsync(), "Id", "Name");
            ViewBag.Country = new SelectList(await repository.GetDbSet<Country>().ToListAsync(), "Id", "Name");
            ViewBag.Genre = new SelectList(await repository.GetDbSet<Genre>().ToListAsync(), "Id", "Name");
            ViewBag.MovieFormat = new SelectList(await repository.GetDbSet<MovieFormat>().ToListAsync(), "Id", "Name");
            ViewBag.MovieProductionCompany = new SelectList(await repository.GetDbSet<MovieProductionCompany>().ToListAsync(), "Id", "Name");
            ViewData["type"] = typeof(Movie);
            ViewData["PartialViewName"] = "MovieCreate";
            return View();
        }

        override public async Task<IActionResult> Edit(int id)
        {
            var entity = await repository.FindEntityAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            ViewBag.AgeRating = new SelectList(await repository.GetDbSet<AgeRating>().ToListAsync(), "Id", "Name");
            ViewBag.Country = new SelectList(await repository.GetDbSet<Country>().ToListAsync(), "Id", "Name");
            ViewBag.Genre = new SelectList(await repository.GetDbSet<Genre>().ToListAsync(), "Id", "Name");
            ViewBag.MovieFormat = new SelectList(await repository.GetDbSet<MovieFormat>().ToListAsync(), "Id", "Name");
            ViewBag.MovieProductionCompany = new SelectList(await repository.GetDbSet<MovieProductionCompany>().ToListAsync(), "Id", "Name");
            ViewData["type"] = typeof(Movie);
            ViewData["PartialViewName"] = "MovieCreate";
            return View(entity);
        }

        override public async Task<IActionResult> Details(int id)
        {
            var entity = await repository.getDbSet()
                .Include(movie => movie.AgeRating)
                .Include(movie => movie.Country)
                .Include(movie => movie.Genre)
                .Include(movie => movie.MovieFormat)
                .Include(movie => movie.MovieProductionCompany)
                .FirstAsync(movie => movie.Id == id);
            if (entity == null)
            {
                return NotFound();
            }
            ViewData["type"] = typeof(Movie);
            ViewData["PartialViewName"] = "MovieDetails";
            return View(entity);
        }

        override public async Task<IActionResult> Delete(int id)
        {
            var entity = await repository.getDbSet()
                .Include(movie => movie.AgeRating)
                .Include(movie => movie.Country)
                .Include(movie => movie.Genre)
                .Include(movie => movie.MovieFormat)
                .Include(movie => movie.MovieProductionCompany)
                .FirstAsync(movie => movie.Id == id);
            if (entity == null)
            {
                return NotFound();
            }
            ViewData["type"] = typeof(Movie);
            ViewData["PartialViewName"] = "MovieDetails";
            return View(entity);
        }
    }
}
