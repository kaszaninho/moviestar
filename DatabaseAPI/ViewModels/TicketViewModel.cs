namespace DatabaseAPI.ViewModels
{
    public class TicketViewModel
    {
        public int? MovieId { get; set; }
        public string? MovieName { get; set; }
        public string? SeatNumber { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? TicketPrice { get; set; }
        public int? TicketId { get; set; }
        public string? MovieDate { get; set; }
        public int? ScreenNumber { get; set; }
    }
}
