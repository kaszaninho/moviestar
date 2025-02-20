using DatabaseAPI.Data;
using DatabaseAPI.Models.CinemaMovie;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortalWWW.Models;

namespace PortalWWW.Controllers
{
    [Route("[controller]")]
    public class MovieController : Controller
    {
        private readonly DatabaseAPIContext dbContext;
        private readonly static string DATE_FORMAT = "dd/MM/yyyy";

        public MovieController(DatabaseAPIContext context)
        {
            dbContext = context;
        }

        [HttpGet("Index")]
        public ActionResult Index()
        {
            List<Movie> entities = dbContext.Movie
                .Include(mov => mov.Genre)
                .Include(mov => mov.AgeRating)
                .Include(mov => mov.Country)
                .Include(mov => mov.Screenings)
                .ToList();
            return View(entities);
        }

        [HttpPost("IndexWithScreenings")]
        public ActionResult IndexWithScreenings(string? selectedDate)
        {
            if (selectedDate == null)
            {
                return RedirectToAction("Index");
            }
            var properDate = DateTime.ParseExact(selectedDate, DATE_FORMAT, null).Date;
            List<Movie> entities = dbContext.Movie
                .Include(mov => mov.Genre)
                .Include(mov => mov.AgeRating)
                .Include(mov => mov.Country)
                .Include(mov => mov.Screenings)
                .ToList();
            List<Movie> moviesToShow = new List<Movie>();
            entities.ForEach(mov =>
            {
                if (mov.Screenings.Any(scr => scr.StartDate >= properDate && scr.StartDate <= properDate.AddDays(1)))
                {
                    moviesToShow.Add(mov);
                }
            });
            ViewData["selectedDate"] = selectedDate;
            return View(moviesToShow);
        }

        [HttpGet("ShowMovieDetails")]
        public ActionResult ShowMovieDetails(int id)
        {
            var entity = dbContext.Movie
                .Include(mov => mov.Genre)
                .Include(mov => mov.AgeRating)
                .Include(mov => mov.Country)
                .Include(mov => mov.Screenings)
                .Include(mov => mov.MovieFormat)
                .Include(mov => mov.MovieProductionCompany)
                .FirstOrDefault(mov => mov.Id == id);
            return View(entity);
        }

        [HttpPost("ChooseSeats")]
        public IActionResult ChooseSeats(int screeningId)
        {
            var screeningSeats = dbContext.ScreeningSeat
                .Include(ss => ss.Seat)
                .Include(ss => ss.Screening)
                .ThenInclude(ss => ss.Movie)
                .Where(ss => ss.ScreeningId == screeningId)
                .ToList();
            ViewData["ScreeningId"] = screeningSeats.First().ScreeningId;
            ViewData["MovieName"] = screeningSeats.First().Screening.Movie.Name;
            ViewData["date"] = screeningSeats.First().Screening.StartDate.Value.Date.ToString("dd-MM-yyyy")
                + ", " + screeningSeats.First().Screening.StartDate.Value.ToString("HH:mm")
                + " - " + screeningSeats.First().Screening.EndDate.Value.ToString("HH:mm");

            return View(screeningSeats);
        }


        [HttpGet("DetailsOfChoice")]
        public IActionResult DetailsOfChoice(string seatIds)
        {
            var seatIdList = seatIds.Split(',').Select(int.Parse).ToList();
            var chosenSeats = dbContext.ScreeningSeat.Include(item => item.Screening).ThenInclude(item => item.Movie).Where(item => seatIdList.Contains(item.Id)).ToList();
            var movieData = chosenSeats.First();
            ViewData["ScreeningId"] = movieData.ScreeningId;
            ViewData["MovieName"] = movieData.Screening.Movie.Name;
            ViewData["date"] = movieData.Screening.StartDate.Value.Date.ToString("dd-MM-yyyy")
                + ", " + movieData.Screening.StartDate.Value.ToString("HH:mm")
                + " - " + movieData.Screening.EndDate.Value.ToString("HH:mm");
            return View(chosenSeats);
        }

        [HttpPost("DetailsOfChosenSeats")]
        public async Task<ActionResult> DetailsOfChosenSeats([FromBody] SeatSelectionModel selection)
        {
            if (selection?.SelectedSeats == null || !selection.SelectedSeats.Any())
            {
                return BadRequest(new { message = "No seats selected." });
            }
            var selectedSeats = selection.SelectedSeats;
            var chosenSeats = dbContext.ScreeningSeat.Include(item => item.Screening).ThenInclude(item => item.Movie).Where(item => selectedSeats.Contains(item.Id)).ToList();
            var movieData = chosenSeats.First();
            var screeningId = movieData.ScreeningId;
            var movieName = movieData.Screening.Movie.Name;
            var date = movieData.Screening.StartDate.Value.Date.ToString("dd-MM-yyyy")
                + ", " + movieData.Screening.StartDate.Value.ToString("HH:mm")
                + " - " + movieData.Screening.EndDate.Value.ToString("HH:mm");
            var redirectUrl = Url.Action("DetailsOfChoice", "Movie", new
            {
                screeningId = screeningId,
                movieName = movieName,
                date = date,
                seatIds = string.Join(",", selectedSeats)
            });

            return Json(new { redirectUrl });
        }

        [HttpGet("PaymentChoice")]
        public ActionResult PaymentChoice()
        {
            return View();
        }
    }
}
