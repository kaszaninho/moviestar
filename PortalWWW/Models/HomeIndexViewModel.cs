using DatabaseAPI.Models.CinemaMovie;

namespace PortalWWW.Models
{
	public class HomeIndexViewModel
	{
		public List<MovieCarousel>? MovieCarouselList { get; set; }
		public List<MovieCarousel>? TopTenMoviesList { get; set; }
		public List<Movie>? MovieList { get; set; }
		public List<MovieNews>? LatestMovies { get; set; }
		public List<MovieNews>? PopularMovies { get; set; }
		public List<MovieNews>? OldestMovies { get; set; }
		public Movie? BestMovieOfMonth { get; set; }
	}

	public class MovieCarousel
	{
		public string? Title { get; set; }
		public string? PhotoUrl { get; set; }
		public int? MovieId { get; set; }
	}

	public class MovieNews
	{
		public string? Title { get; set; }
		public string? PhotoUrl { get; set; }
		public int? MovieId { get; set; }
		public string? Genre { get; set; }
		public int? Duration { get; set; }
		public string? Description { get; set; }
		public string? ReleaseDate { get; set; }
	}
}
