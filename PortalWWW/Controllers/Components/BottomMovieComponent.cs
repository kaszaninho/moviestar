using DatabaseAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortalWWW.Models;

namespace PortalWWW.Controllers.Components
{
    public class BottomMovieComponent : ViewComponent
    {
        private readonly DatabaseAPIContext context;

        public BottomMovieComponent(DatabaseAPIContext context)
        {
            this.context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var movieList = await context.Movie.Select(x => new MovieCarousel
            {
                MovieId = x.Id,
                PhotoUrl = x.imageUrl,
                Title = x.Name

            }).ToListAsync();
            return View("BottomMovieComponent", movieList.Take(Math.Min(10, movieList.Count)));
        }
    }
}
