using BusinessLogic;
using BusinessLogic.Helpers;
using DatabaseAPI.Data;
using DatabaseAPI.Models.CinemaMovie;
using DatabaseAPI.Models.General;
using DatabaseAPI.ViewModels;
using HelperProject;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PortalWWW.Models;
using ServiceStack;
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

            var bestMovieId = movies.OrderByDescending(mov => mov.Screenings.Sum(scr => scr.ScreeningSeats.Sum(ss => ss.IsTaken ?? false ? 1 : 0))).First()?.Id;
            var bestMovie = await dbContext.Movie
                .Include(mov => mov.Genre)
                .Include(mov => mov.Actors)
                .Include(mov => mov.Directors)
                .FirstAsync(x => x.Id == bestMovieId);


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
                BestMovieOfMonth = bestMovie
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

        [HttpPost("AddCustomerQuery")]
        public async Task<IActionResult> AddCustomerQuery(CustomerQuery entity)
        {
            if (entity != null)
            {
                entity.CreatedAt = DateTime.Now;
                entity.ModifiedAt = DateTime.Now;
                entity.IsActive = true;
                entity.IsAnswered = false;
                await dbContext.AddAsync(entity);
                await dbContext.SaveChangesAsync();

                TempData["SuccessMessage"] = "Question was sent! Please await your response.";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["FailedMessage"] = "There was problem with sending your query!";
                return RedirectToAction("Index");
            }
        }

        [HttpPost("AddSubscriber")]
        public async Task<IActionResult> AddSubscriber(string email)
        {
            var entity = await dbContext.Subscriber.Where(x => x.Email == email).ToListAsync();
            if (entity.Count > 0)
            {
                TempData["FailedMessage"] = "Email is already subscribing!";
                return RedirectToAction("Index");
            }
            else
            {
                var newSubscriber = new Subscriber
                {
                    CreatedAt = DateTime.Now,
                    ModifiedAt = DateTime.Now,
                    Name = email,
                    Email = email,
                    IsActive = true,
                    Description = ""
                };
                await dbContext.AddAsync(newSubscriber);
                await dbContext.SaveChangesAsync();
                TempData["SuccessMessage"] = "Email subscribed!";
                return RedirectToAction("Index");
            }
        }

        [HttpGet("TicketReportForUser")]
        public async Task<IActionResult> TicketsReportForUser()
        {
            return View();
        }

        [HttpGet("GetTicketsReportForUser")]
        public async Task<IActionResult> GetTicketsReportForUser()
        {
            var user = await userManager.GetUserAsync(User);
            if (user == null)
            {
                return Json(new { success = false, message = "User is not logged in" });
            }
            var ticketList = dbContext.Ticket
                .Include(x => x.Invoice)
                .Include(x => x.ScreeningSeat)
                .ThenInclude(x => x.Screening)
                .ThenInclude(x => x.Movie)
                .Include(x => x.ScreeningSeat)
                .ThenInclude(x => x.Screening)
                .ThenInclude(x => x.Screen)
                .Where(x => x.Invoice.UserId == user.Id)
                .AsEnumerable()
                .Select(x =>
                {
                    var startDate = x.ScreeningSeat.Screening.StartDate ?? DateTime.Now;
                    var endDate = x.ScreeningSeat.Screening.EndDate ?? DateTime.Now;
                    return new TicketViewModel
                    {
                        StartDate = startDate,
                        EndDate = endDate,
                        MovieId = x.ScreeningSeat.Screening.MovieId,
                        MovieName = x.ScreeningSeat.Screening.Movie.Name,
                        SeatNumber = x.ScreeningSeat.Name,
                        TicketId = x.Id,
                        TicketPrice = x.ScreeningSeat.Screening.Movie.TicketPrice,
                        MovieDate = $"{startDate.ToShortDateString()}, {startDate.TimeOfDay} - {endDate.TimeOfDay}",
                        ScreenNumber = x.ScreeningSeat.Screening.Screen.RoomNumber
                    };
                });
            return Json(new { data = ticketList });
        }

        [HttpPost("GenerateTicket")]
        public async Task<IActionResult> GenerateTicket([FromBody] int ticketId)
        {
            var ticket = dbContext.Ticket
                .Include(x => x.ScreeningSeat)
                .ThenInclude(x => x.Screening)
                .ThenInclude(x => x.Movie)
                .Include(x => x.ScreeningSeat)
                .ThenInclude(x => x.Screening)
                .ThenInclude(x => x.Screen)
                .First(x => x.Id == ticketId);
            if (ticket == null)
            {
                return Json(new { success = false, message = "Ticket not found" });
            }
            var ticketInvoiceModel = new TicketInvoiceModel
            {
                Id = ticket.Id,
                MovieName = ticket.ScreeningSeat.Screening.Movie.Name,
                RoomNumber = ticket.ScreeningSeat.Screening.Screen.RoomNumber,
                seatCode = ticket.ScreeningSeat.Name,
                StartDate = ticket.ScreeningSeat.Screening.StartDate
            };
            TicketGenerator.GenerateTicket(ticketInvoiceModel, null);
            return Json(new { success = true, message = "Ticket was generated" });
        }
    }
}
