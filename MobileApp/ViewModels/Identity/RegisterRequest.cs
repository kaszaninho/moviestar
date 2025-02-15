using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MobileApp.ViewModels.Identity
{
    public class RegisterRequest
    {
        [JsonPropertyName("email")]
        public string Email { get; set; } = null!;

        [JsonPropertyName("password")]
        public string Password { get; set; } = null!;

        [JsonPropertyName("firstName")]
        public string FirstName { get; set; } = null!;

        [JsonPropertyName("MiddleName")]
        public string? MiddleName { get; set; }

        [JsonPropertyName("lastName")]
        public string LastName { get; set; } = null!;

        [JsonPropertyName("streetName")]
        public string StreetName { get; set; } = null!;

        [JsonPropertyName("houseNumber")]
        public int HouseNumber { get; set; }

        [JsonPropertyName("apartmentNumber")]
        public int? ApartmentNumber { get; set; }

        [JsonPropertyName("eirCode")]
        public string EirCode { get; set; } = null!;

        [JsonPropertyName("dateOfBirth")]
        public string DateOfBirth { get; set; } = null!;

        [JsonPropertyName("city")]
        public string City { get; set; } = null!;
        [JsonPropertyName("countryId")]
        public int CountryId { get; set; }

    }
}
