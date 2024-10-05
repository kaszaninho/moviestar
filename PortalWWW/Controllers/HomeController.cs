using DatabaseAPI.Data;
using DatabaseAPI.Models.CinemaMovie;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortalWWW.Models;
using System.Collections;
using System.Diagnostics;

namespace PortalWWW.Controllers
{
    public class HomeController : Controller
    {
        private readonly DatabaseAPIContext dbContext;

        public HomeController(DatabaseAPIContext context)
        {
            dbContext = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(dbContext.Movie != null ? await dbContext.Movie.ToListAsync() : new List<Movie>());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult OnGetGetMoviesByDate(string date)
        {
            DateTime selectedDate = DateTime.Parse(date);
            // List<Movie> movies = _movieService.GetMoviesByDate(selectedDate);

            List<Movie> movies = new();

            return PartialView("_MovieListPartial", movies);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
