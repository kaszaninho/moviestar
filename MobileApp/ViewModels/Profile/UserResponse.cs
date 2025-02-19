using MobileApp.ViewModels.Invoice;
using System.Text.Json.Serialization;

namespace MobileApp.ViewModels.Profile
{
    public class UserResponse
    {
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }
        [JsonPropertyName("middleName")]
        public string? MiddleName { get; set; }
        [JsonPropertyName("lastName")]
        public string LastName { get; set; }
        [JsonPropertyName("dateOfBirth")]
        public DateTime DateOfBirth { get; set; }
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("userName")]
        public string UserName { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("emailConfirmed")]
        public bool EmailConfirmed { get; set; }
        [JsonPropertyName("phoneNumber")]
        public string PhoneNumber { get; set; }
        [JsonPropertyName("country")]
        public string Country { get; set; }
        [JsonPropertyName("phoneNumberConfirmed")]
        public bool PhoneNumberConfirmed { get; set; }
        [JsonPropertyName("twoFactorEnabled")]
        public bool TwoFactorEnabled { get; set; }
        [JsonPropertyName("address")]
        public AddressResponse Address { get; set; }
    }

}
