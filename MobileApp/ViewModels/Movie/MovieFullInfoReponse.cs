using MobileApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MobileApp.ViewModels.Movie
{
    public class MovieFullInfoReponse
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("movieId")]
        public int MovieId { get; set; }

        [JsonPropertyName("ageRating")]
        public string AgeRating { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("genre")]
        public string Genre { get; set; }

        [JsonPropertyName("duration")]
        public int Duration { get; set; }

        [JsonPropertyName("ticketPrice")]
        public double TicketPrice { get; set; }

        [JsonPropertyName("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonPropertyName("movieFormat")]
        public string MovieFormat { get; set; }

        [JsonPropertyName("movieProductionCompany")]
        public string MovieProductionCompany { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("releaseDate")]
        public DateTime ReleaseDate { get; set; }

        [JsonPropertyName("screenings")]
        public List<MiniScreeningResponse> Screenings { get; set; }
        public string FullImageUrl => AppSettings.IMAGE_BASE_URL + ImageUrl.Replace('\\', '/');
    }

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
