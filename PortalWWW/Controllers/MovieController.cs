using DatabaseAPI.Data;
using DatabaseAPI.Models.CinemaMovie;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        /**
         * Returns main view for a Choosing a screening.
         * You should see choice for a date or a movie
         */
        public ActionResult Index()
        {
            return View();
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
                .Where(item => item.MovieId ==  movieId && item.StartDate.Value.Date.Equals(date.Date)).ToList());
        }

        public ActionResult ChooseSeat(int screeningId)
        {
            //list of seats for a screeening -> screening.screeningseats -> it'll be populated from seats for a screen
            var seatsForScreening = dbContext.ScreeningSeat.Where(item => item.ScreeningId == screeningId).ToList();
            return View(seatsForScreening);
        }

        public ActionResult DetailsOfChoice(string[] checkboxValues)
        {
            var datas = dbContext.ScreeningSeat.Include(x => x.Screening).ThenInclude(x => x.Movie).First(item => item.Id == int.Parse(checkboxValues[0]));
            ViewData["ScreeningId"] = datas.ScreeningId;
            ViewData["MovieName"] = datas.Screening.Movie.Name;
            ViewData["Date"] = datas.Screening.StartDate.Value.Date.ToString("dd-MM-yyyy")
                + ", " + datas.Screening.StartDate.Value.ToString("HH:mm") 
                + " - " + datas.Screening.EndDate.Value.ToString("HH:mm");
            ViewBag.CheckboxValues = checkboxValues;
            return View();
        }

        public ActionResult PaymentChoice()
        {
            return View();
        }
    }
}
