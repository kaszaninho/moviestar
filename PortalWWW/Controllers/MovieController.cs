using DatabaseAPI.Data;
using DatabaseAPI.Models.CinemaMovie;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortalWWW.Models;
using ServiceStack;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PortalWWW.Controllers
{
	public class MovieController : Controller
	{
		private readonly DatabaseAPIContext dbContext;
		private readonly static string DATE_FORMAT = "MM/dd/yyyy";

		public MovieController(DatabaseAPIContext context)
		{
			dbContext = context;
		}

		public ActionResult Index(DateTime? date)
        {
            var startDate = date.HasValue ? date.Value : new DateTime(2022, 01, 01);
            var endDate = date.HasValue ? date.Value.AddDays(1) : new DateTime(2025, 12, 31);
			var hasShowAllMovies = !date.HasValue;
            List<Movie> entities = dbContext.Movie
                .Include(mov => mov.Genre)
                .Include(mov => mov.AgeRating)
                .Include(mov => mov.Country)
                .Include(mov => mov.Screenings)
                .ToList();
            List<Movie> moviesToShow = new List<Movie>();
            entities.ForEach(mov =>
            {
                if (mov.Screenings.Any(scr => scr.StartDate >= startDate && scr.StartDate <= endDate))
                {
                    moviesToShow.Add(mov);
                }
            });
			return View(hasShowAllMovies ? entities : moviesToShow);
        }

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

		[HttpPost]
		public ActionResult ChooseMovieBasedOnDate(string selectedDate)
		{
			var properDate = DateTime.ParseExact(selectedDate, DATE_FORMAT, null).Date;
			List<Movie> movies = dbContext.Movie.ToList();
			Dictionary<Movie, List<Screening>> moviesWithScreenings = new Dictionary<Movie, List<Screening>>();

			foreach (Movie movie in movies)
			{
				var screeningsWithinDate = dbContext.Screening.Where(item => item.MovieId == movie.Id).Where(item => item.StartDate.Value.Date <= properDate).ToList();
				// I need to think about null exception pointer here - when can happen? If in real-time scenario can happen? If yes, how to deal with it?
				//List<Screening> screeningsForMovie = dbContext.Movie.First(item => item.Id == movie.Id).Screenings
				//    .Where(screening => screening.StartDate.GetValueOrDefault().Date == date.Date).ToList();
				if (screeningsWithinDate.Count > 0)
				{
					moviesWithScreenings.Add(movie, screeningsWithinDate);
				}
			}
			ViewBag.Movies = movies;
			ViewBag.MoviesWithScreenings = moviesWithScreenings;

			return View();
		}

		public async Task<IActionResult> ShowScreeningsForMovie()
		{
			//TODO: I'll have to include more information when it'll be added (.Inlude(screening...))
			return View(await dbContext.Movie.Include(item => item.Screenings.OrderBy(item => item.StartDate)).ToListAsync());
		}

		public ActionResult GetScreenings(int movieId, DateTime date)
		{
			return PartialView("ScreeningsForMovie", dbContext.Screening
				.Where(item => item.MovieId == movieId && item.StartDate.Value.Date.Equals(date.Date)).ToList());
		}

		public ActionResult ChooseSeat(int screeningId)
		{
			//list of seats for a screeening -> screening.screeningseats -> it'll be populated from seats for a screen
			var seatsForScreening = dbContext.ScreeningSeat.Where(item => item.ScreeningId == screeningId).ToList();
			return View(seatsForScreening);
		}

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

		[HttpPost]
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

		public ActionResult PaymentChoice()
		{
			return View();
		}
	}
}
