using System.Text.Json.Serialization;

namespace MobileApp.ViewModels.Movie
{
    public class MiniScreeningResponse
    {
        [JsonPropertyName("startDate")]
        public DateTime StartDate { get; set; }
        [JsonPropertyName("endDate")]
        public DateTime EndDate { get; set; }
        [JsonPropertyName("movieId")]
        public int MovieId { get; set; }
        [JsonPropertyName("screeningId")]
        public int? ScreeningId { get; set; }
    }
}
