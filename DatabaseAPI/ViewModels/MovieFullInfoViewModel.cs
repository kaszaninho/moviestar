namespace DatabaseAPI.ViewModels
{
    public class MovieFullInfoViewModel
    {
        public string? Title { get; set; }
        public int? MovieId { get; set; }
        public string? AgeRating { get; set; }
        public string? Country { get; set; }
        public string? Genre { get; set; }
        public int? Duration { get; set; }
        public decimal? TicketPrice { get; set; }
        public string? ImageUrl { get; set; }
        public string? MovieFormat { get; set; }
        public string? MovieProductionCompany { get; set; }
        public int? MovieProductionCompanyId { get; set; }
        public string? Description { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public ICollection<MiniScreeningViewModel>? Screenings { get; set; }
    }
}
