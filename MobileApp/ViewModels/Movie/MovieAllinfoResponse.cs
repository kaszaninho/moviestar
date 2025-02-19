using System.Text.Json.Serialization;

namespace MobileApp.ViewModels.Movie
{
    public class MovieAllinfoResponse
    {
        [JsonPropertyName("earliestScreeningsWithMovies")]
        public IEnumerable<Screening> EarliestScreeningsWithMovies { get; set; }
        [JsonPropertyName("latestInvoiceWithTickets")]
        public Invoice LatestInvoiceWithTickets { get; set; }
    }
}
