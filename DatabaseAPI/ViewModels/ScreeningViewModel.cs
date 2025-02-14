namespace DatabaseAPI.ViewModels
{
    public class ScreeningViewModel
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? MovieTitle { get; set; }
        public int? MovieId { get; set; }
        public string? imageUrl { get; set; }
    }
    public class MiniScreeningViewModel
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? MovieId { get; set; }
    }
}
