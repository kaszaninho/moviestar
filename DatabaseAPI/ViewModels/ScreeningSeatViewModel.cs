namespace DatabaseAPI.ViewModels
{
    public class ScreeningSeatViewModel
    {
        public int? ScreeningSeatId { get; set; }
        public int? ScreeningId { get; set; }
        public bool? IsTaken { get; set; }
        public string? SeatNumber { get; set; }
        public decimal? TicketPrice { get; set; }
    }
}
