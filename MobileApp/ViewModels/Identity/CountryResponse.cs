using System.Text.Json.Serialization;

namespace MobileApp.ViewModels.Identity
{
    public class CountryResponse
    {
        [JsonPropertyName("countryName")]
        public string CountryName { get; set; }
        [JsonPropertyName("countryId")]
        public int CountryId { get; set; }
    }
}
