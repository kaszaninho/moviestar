using DatabaseAPI.Data;
using DatabaseAPI.Models.CinemaMovie;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PortalWWW.Controllers.MovieComponents
{
    public class ChooseAMovieComponent : ViewComponent
    {
        private readonly DatabaseAPIContext dbContext;

        public ChooseAMovieComponent(DatabaseAPIContext context)
        {
            dbContext = context;
        }

        /**
         * This method will return up to 3 movies for a short component
         */
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Movie> movies = dbContext.Movie.OrderBy(movie => movie.ModifiedAt).ToList();
            Dictionary<Movie, List<Screening>> moviesWithScreenings = new Dictionary<Movie, List<Screening>>();
            int count = 0;
            foreach (Movie movie in movies)
            {
                var screeningsWithinDate = dbContext.Screening.Where(item => item.MovieId == movie.Id).Where(item => item.StartDate.Value.Date == DateTime.Now.Date).ToList();
                // I need to think about null exception pointer here - when can happen? If in real-time scenario can happen? If yes, how to deal with it?
                //List<Screening> screeningsForMovie = dbContext.Movie.First(item => item.Id == movie.Id).Screenings
                //    .Where(screening => screening.StartDate.GetValueOrDefault().Date == date.Date).ToList();
                if (screeningsWithinDate.Count > 0)
                {
                    moviesWithScreenings.Add(movie, screeningsWithinDate);
                    count++;
                }
                if (count == 3) break;
            }
            ViewBag.MoviesWithScreenings = moviesWithScreenings;
            return View("ChooseAMovieComponent", moviesWithScreenings);
        }
    }
}
