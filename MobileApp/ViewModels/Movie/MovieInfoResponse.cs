using MobileApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MobileApp.ViewModels.Movie
{
    public class MovieInfoResponse
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("movieId")]
        public int? MovieId { get; set; }

        [JsonPropertyName("ageRating")]
        public string AgeRating { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("genre")]
        public string Genre { get; set; }

        [JsonPropertyName("duration")]
        public int? Duration { get; set; }

        [JsonPropertyName("ticketPrice")]
        public decimal? TicketPrice { get; set; }

        [JsonPropertyName("imageUrl")]
        public string ImageUrl { get; set; }
        public string FullImageUrl => AppSettings.IMAGE_BASE_URL + ImageUrl.Replace('\\', '/');
    }
}
