namespace DatabaseAPI.ViewModels
{
    public class MovieInfoViewModel
    {
        public string? Title { get; set; }
        public int? MovieId { get; set; }
        public string? AgeRating { get; set; }
        public string? Country { get; set; }
        public string? Genre { get; set; }
        public int? Duration { get; set; }
        public decimal? TicketPrice { get; set; }
        public string? ImageUrl { get; set; }
    }
}
