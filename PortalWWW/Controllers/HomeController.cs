using BusinessLogic;
using DatabaseAPI.Data;
using DatabaseAPI.Models.CinemaMovie;
using InvoiceSdk.Models.Payments;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PortalWWW.Models;
using ServiceStack;
using System.Collections;
using System.Diagnostics;

namespace PortalWWW.Controllers
{
    [Route("")]
    public class HomeController : Controller
	{
		private readonly DatabaseAPIContext dbContext;
		private readonly UserManager<IdentityUser> userManager;

		public HomeController(DatabaseAPIContext context, UserManager<IdentityUser> userManager)
		{
			dbContext = context;
			this.userManager = userManager;
		}

        [HttpGet("")]
        public async Task<IActionResult> Index()
		{
			var movies = dbContext.Movie != null ? await dbContext.Movie
				.Include(mov => mov.Genre)
				.Include(mov => mov.Screenings)
				.ThenInclude(mov => mov.ScreeningSeats)
				.ToListAsync() : new List<Movie>();

			var homeIndexViewModel = movies.Count > 0 ? new HomeIndexViewModel()
			{
				MovieList = movies,
				MovieCarouselList = movies.Slice(0, 3).Select(mov => new MovieCarousel
				{
					MovieId = mov.Id,
					PhotoUrl = mov.imageUrl,
					Title = mov.Name
				}).ToList(),
                TopTenMoviesList = movies.OrderByDescending(mov => mov.Screenings.Sum(scr => scr.ScreeningSeats.Sum(ss => ss.IsTaken ?? false ? 1 : 0))).ToList().Slice(1, 9).Select(mov => new MovieCarousel
                {
                    MovieId = mov.Id,
                    PhotoUrl = mov.imageUrl,
                    Title = mov.Name
                }).ToList(),
                LatestMovies = movies.OrderByDescending(mov => mov.CreatedAt).ToList().Slice(0, 4).Select(mov => new MovieNews
				{
					MovieId = mov.Id,
					Description = mov.Description.Substring(0, Math.Min(150, mov.Description.Length))
											+ "...",
					Genre = mov.Genre.Name,
					Duration = mov.Duration,
					PhotoUrl = mov.imageUrl,
					Title = mov.Name,
					ReleaseDate = mov.CreatedAt.Value.Year.ToString()
				}).ToList(),
                OldestMovies = movies.OrderBy(mov => mov.CreatedAt).ToList().Slice(0, 4).Select(mov => new MovieNews
				{
					MovieId = mov.Id,
					Description = mov.Description.Substring(0, Math.Min(150, mov.Description.Length))
											+ "...",
					Genre = mov.Genre.Name,
					Duration = mov.Duration,
					PhotoUrl = mov.imageUrl,
					Title = mov.Name,
					ReleaseDate = mov.CreatedAt.Value.Year.ToString()
				}).ToList(),
				PopularMovies = movies.OrderByDescending(mov => mov.Screenings.Sum(scr => scr.ScreeningSeats.Sum(ss => ss.IsTaken ?? false ? 1 : 0))).ToList().Slice(0, 4).Select(mov => new MovieNews
				{
					MovieId = mov.Id,
					Description = mov.Description.Substring(0, Math.Min(150, mov.Description.Length))
											+ "...",
					Genre = mov.Genre.Name,
					Duration = mov.Duration,
					PhotoUrl = mov.imageUrl,
					Title = mov.Name,
					ReleaseDate = mov.CreatedAt.Value.Year.ToString()
				}).ToList(),
				BestMovieOfMonth = movies.OrderByDescending(mov => mov.Screenings.Sum(scr => scr.ScreeningSeats.Sum(ss => ss.IsTaken ?? false ? 1 : 0))).First()
            } : new HomeIndexViewModel();

			return View(homeIndexViewModel);
		}

        [HttpGet("InvoiceReportForUser")]
        public IActionResult InvoiceReportForUser(DateTime? start, DateTime? end, string mode = "all")
		{
			ViewBag.PaymentStatuses = new SelectList(Constans.PaymentStatuses);
			ViewData["startDate"] = start == null ? new DateTime(2023, 1, 1) : start;
			ViewData["endDate"] = end == null ? new DateTime(2025, 12, 31) : end;
			ViewData["paymentMethod"] = mode;
			return View();
		}

		[HttpPost("GetAllInvoicesForUser")]
		public async Task<IActionResult> GetAllInvoicesForUser(DateTime? start, DateTime? end, string mode = "all")
		{
			DateTime? startDate = start == null ? new DateTime(2023, 1, 1) : start;
			DateTime? endDate = end == null ? new DateTime(2025, 12, 31) : end;
			var user = await userManager.GetUserAsync(User);
			if (user == null)
			{
				return Json(new { success = false, message = "User is not logged in" });
			}
			var invoices = dbContext.Invoice
				.Include(inv => inv.PaymentMethod)
				.Where(inv => inv.CreatedAt >= startDate && inv.CreatedAt <= endDate && inv.UserId == user.Id)
				.ToList();
			var invoicesToShow = invoices.Where(inv => mode == "all" || inv.PaymentStatus == mode).ToList();
			return Json(new { data = invoicesToShow });
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

		[Route("~/Home/More/{name}")]
		public async Task<IActionResult> More(string name)
		{
			var website = await dbContext.Website.FirstOrDefaultAsync(x => x.Name == name);

			return View("More", website);
		}

        [HttpGet("Contact")]
        public IActionResult Contact()
		{
			return View();
		}
	}
}
