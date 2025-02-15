using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

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
