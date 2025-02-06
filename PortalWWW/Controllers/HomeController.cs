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
using System.Collections;
using System.Diagnostics;

namespace PortalWWW.Controllers
{
    public class HomeController : Controller
    {
        private readonly DatabaseAPIContext dbContext;
        private readonly UserManager<IdentityUser> userManager;

        public HomeController(DatabaseAPIContext context, UserManager<IdentityUser> userManager)
        {
            dbContext = context;
            this.userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            return View(dbContext.Movie != null ? await dbContext.Movie.ToListAsync() : new List<Movie>());
        }

        public IActionResult InvoiceReportForUser(DateTime? start, DateTime? end, string mode = "all")
        {
            ViewBag.PaymentStatuses = new SelectList(Constans.PaymentStatuses);
            ViewData["startDate"] = start == null ? new DateTime(2023, 1, 1) : start;
            ViewData["endDate"] = end == null ? new DateTime(2025, 12, 31) : end;
            ViewData["paymentMethod"] = mode;
            return View();
        }

        [HttpGet]
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

        [Route("~/Home/More/{name}")]
        public async Task<IActionResult> More(string name)
        {
            var website = await dbContext.Website.FirstOrDefaultAsync(x => x.Name == name);

            return View("More", website);
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
