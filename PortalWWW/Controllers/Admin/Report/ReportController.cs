using DatabaseAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServiceStack;
using System.Collections;

namespace PortalWWW.Controllers.Admin.Report
{
    public class ReportController : Controller
    {

        private readonly DatabaseAPIContext context;

        public ReportController(DatabaseAPIContext context)
        {
            this.context = context;
        }

        public IActionResult MoviesGenerator(DateTime? start, DateTime? end)
        {
            DateTime? startDate = start == null ? new DateTime(2023, 1, 1) : start;
            DateTime? endDate = end == null ? new DateTime(2025, 12, 31) : end;
            var movies = context.Movie.Include(m => m.Genre).Where(movie => movie.CreatedAt >= startDate && movie.CreatedAt < endDate).ToList();

            var genres = context.Genre.Include(m => m.Movies).OrderBy(g => g.Name).ToList();

            HashSet<string> labels = new HashSet<string>();
            ArrayList genresCount = new ArrayList();
            for (int i = 0; i < genres.Count; i++)
            {
                genresCount.Add(genres[i].Movies.Count);
                labels.Add(genres[i].Name);
            }
            ArrayList percentages = new ArrayList();

            var chartData = new
            {
                labels = labels,
                datasets = new[]
                {
                    new
                    {
                        label = $"Movies' count in each genre from {startDate.GetValueOrDefault().ToShortDateString()} do {endDate.GetValueOrDefault().ToShortDateString()}",
                        data = genresCount,
                        backgroundColor = "rgba(75, 12, 12, 0.2)",
                        borderColor = "rgba(75, 12, 12, 1)",
                        borderWidth = 1
                    },
                    new
                    {
                        label = $"Genres' diversity from {startDate.GetValueOrDefault().ToShortDateString()} do {endDate.GetValueOrDefault().ToShortDateString()}",
                        data = genresCount,
                        backgroundColor = "rgba(75, 12, 12, 0.2)",
                        borderColor = "rgba(75, 12, 12, 1)",
                        borderWidth = 1
                    }
                }
            };

            return View(chartData);
        }

        public IActionResult InvoiceGenerator()
        {
            return View();
        }

        public IActionResult TicketsGenerator()
        {
            return View();
        }

        public IActionResult SeatsGenerator()
        {
            return View();
        }

        public IActionResult AccountsGenerator()
        {
            return View();
        }
    }
}
