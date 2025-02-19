using MobileApp.Services;
using System.Text.Json.Serialization;

namespace MobileApp.ViewModels.Movie
{
    public class Screening
    {
        [JsonPropertyName("startDate")]
        public DateTime StartDate { get; set; }
        [JsonPropertyName("endDate")]
        public DateTime EndDate { get; set; }
        [JsonPropertyName("movieTitle")]
        public string MovieTitle { get; set; }
        [JsonPropertyName("movieId")]
        public int MovieId { get; set; }
        [JsonPropertyName("imageUrl")]
        public string ImageUrl { get; set; }
        public string FullImageUrl => AppSettings.IMAGE_BASE_URL + ImageUrl.Replace('\\', '/');
    }
}
