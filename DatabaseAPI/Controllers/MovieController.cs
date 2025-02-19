using DatabaseAPI.Data;
using DatabaseAPI.Models.CinemaMovie;
using DatabaseAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatabaseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly DatabaseAPIContext _context;

        public MovieController(DatabaseAPIContext context)
        {
            _context = context;
        }

        // GET: api/Movie
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMovie()
        {
            return await _context.Movie.ToListAsync();
        }

        // GET: api/Movie
        [HttpGet("withscreenings")]
        public async Task<ActionResult<IEnumerable<MovieInfoViewModel>>> GetMoviesWithScreenings()
        {
            return await _context.Movie.Include(mov => mov.Genre).Include(mov => mov.AgeRating).Include(mov => mov.Screenings).Include(mov => mov.Country)
                .Select(mov => new MovieInfoViewModel
                {
                    AgeRating = mov.AgeRating.Name,
                    Country = mov.Country.Name,
                    Duration = mov.Duration,
                    Genre = mov.Genre.Name,
                    ImageUrl = mov.imageUrl,
                    MovieId = mov.Id,
                    TicketPrice = mov.TicketPrice,
                    Title = mov.Name
                }).ToListAsync();
        }

        // GET: api/Movie/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MovieFullInfoViewModel>> GetMovie(int id)
        {
            var movie = await _context.Movie
                .Include(movie => movie.AgeRating)
                .Include(movie => movie.Country)
                .Include(movie => movie.Genre)
                .Include(movie => movie.MovieFormat)
                .Include(movie => movie.MovieProductionCompany)
                .Include(movie => movie.Screenings)
                .FirstAsync(movie => movie.Id == id);

            if (movie == null)
            {
                return NotFound();
            }
            var movieViewModel = new MovieFullInfoViewModel
            {
                AgeRating = movie.AgeRating.Name,
                Country = movie.Country.Name,
                Description = movie.Description,
                Duration = movie.Duration,
                Genre = movie.Genre.Name,
                ImageUrl = movie.imageUrl,
                MovieId = movie.Id,
                TicketPrice = movie.TicketPrice,
                Title = movie.Name,
                MovieFormat = movie.MovieFormat.Name,
                MovieProductionCompany = movie.MovieProductionCompany.Name,
                ReleaseDate = movie.CreatedAt,
                Screenings = movie.Screenings.Select(scr => new MiniScreeningViewModel
                {
                    EndDate = scr.EndDate,
                    StartDate = scr.StartDate,
                    MovieId = movie.Id,
                    ScreeningId = scr.Id
                }).ToList()
            };
            return movieViewModel;
        }
    }
}
