using DatabaseAPI.Models.Abstract;

namespace DatabaseAPI.Models.CinemaMovie
{
    public class MovieReview : DictionaryTable
    {
        public Movie? Movie { get; set; }
        public int? MovieId { get; set; }
        public string? Author { get; set; }
        public int? Rating { get; set; }
        public string? Review { get; set; }
    }
}
