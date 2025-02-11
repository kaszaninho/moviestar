using DatabaseAPI.Data;
using DatabaseAPI.Models.CinemaMovie;
using DatabaseAPI.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatabaseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieUserController : ControllerBase
    {
        private readonly DatabaseAPIContext _context;

        public MovieUserController(DatabaseAPIContext context)
        {
            _context = context;
        }


        // GET: api/MovieUser
        [HttpGet("/{userId}")]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMovie(string userId)
        {
            IOrderedEnumerable<Screening?> screenings = await GatherMoviesBasedOnUser(userId);
            var earliestScreenings = screenings.Take(Math.Min(5, screenings.Count()));
            return earliestScreenings?.Select(scr => scr.Movie)?.ToList();
        }

        private async Task<IOrderedEnumerable<Screening?>> GatherMoviesBasedOnUser(string userId)
        {
            var invList = await _context.Invoice.Include(inv => inv.Tickets).ThenInclude(inv => inv.ScreeningSeat).ThenInclude(inv => inv.Screening).ThenInclude(inv => inv.Movie).Where(inv => inv.UserId == userId).ToListAsync();
            var screenings = invList
                    .SelectMany(inv => inv.Tickets) // Flatten the tickets from all invoices
                    .Select(tick => tick.ScreeningSeat.Screening) // Extract the screenings
                    .OrderBy(screening => screening.StartDate);
            return screenings;
        }


        // GET: api/MovieUser/getAllInfo/5
        [HttpGet("getAllInfo/{userId}")]
        public async Task<ActionResult<MovieListsViewModel>> GetMultipleMoviesInfo(string userId)
        {
            var invList = await _context.Invoice.Include(inv => inv.Tickets).ThenInclude(inv => inv.ScreeningSeat).ThenInclude(inv => inv.Screening).ThenInclude(inv => inv.Movie).Where(inv => inv.UserId == userId).ToListAsync();
            var screenings = invList
                    .SelectMany(inv => inv.Tickets) // Flatten the tickets from all invoices
                    .Select(tick => tick.ScreeningSeat.Screening).DistinctBy(som => som.Id) // Extract the screenings
                    .OrderBy(screening => screening.StartDate);
            var earliestScreenings = screenings.Take(Math.Min(3, screenings.Count())).Select(scr => new ScreeningViewModel
            {
                EndDate = scr.EndDate,
                StartDate = scr.StartDate,
                MovieId = scr.MovieId,
                MovieTitle = scr.Movie.Name,
                imageUrl = scr.Movie.imageUrl
            }).ToList();
            var latestInvoice = invList.OrderBy(inv => inv.CreatedAt).First();
            var latestInvoiceViewModel = new MiniInvoiceViewModel
            {
                CreatedAt = latestInvoice.CreatedAt,
                InvoiceId = latestInvoice.InvoiceId,
                OrderStatus = latestInvoice.OrderStatus,
                PaymentStatus = latestInvoice.PaymentStatus,
                TotalSum = latestInvoice.TotalSum
            };
            return new MovieListsViewModel
            {
                EarliestScreeningsWithMovies = earliestScreenings,
                LatestInvoiceWithTickets = latestInvoiceViewModel
            };
        }
    }
}
