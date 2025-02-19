using System.Text.Json.Serialization;

namespace MobileApp.ViewModels.Invoice
{
    public class TicketResponse
    {
        [JsonPropertyName("movieId")]
        public int MovieId { get; set; }
        [JsonPropertyName("movieName")]
        public string MovieName { get; set; }
        [JsonPropertyName("seatNumber")]
        public string SeatNumber { get; set; }
        [JsonPropertyName("startDate")]
        public DateTime StartDate { get; set; }
        [JsonPropertyName("endDate")]
        public DateTime EndDate { get; set; }
        [JsonPropertyName("ticketPrice")]
        public decimal? TicketPrice { get; set; }
        [JsonPropertyName("ticketId")]
        public int? TicketId { get; set; }
    }
}

