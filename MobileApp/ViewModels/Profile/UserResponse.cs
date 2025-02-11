using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MobileApp.ViewModels.Profile
{
    public class UserResponse
    {
        [JsonPropertyName("firstName")]
        public string firstName { get; set; }

        [JsonPropertyName("middleName")]
        public object middleName { get; set; }

        [JsonPropertyName("lastName")]
        public string lastName { get; set; }

        [JsonPropertyName("dateOfBirth")]
        public DateTime dateOfBirth { get; set; }

        [JsonPropertyName("address")]
        public Address address { get; set; }

        [JsonPropertyName("addressId")]
        public int addressId { get; set; }

        [JsonPropertyName("userLevel")]
        public object userLevel { get; set; }

        [JsonPropertyName("userLevelId")]
        public int userLevelId { get; set; }

        [JsonPropertyName("userProgressToNextLevel")]
        public int userProgressToNextLevel { get; set; }

        [JsonPropertyName("favouriteMovies")]
        public object favouriteMovies { get; set; }

        [JsonPropertyName("favouriteActors")]
        public object favouriteActors { get; set; }

        [JsonPropertyName("role")]
        public object role { get; set; }

        [JsonPropertyName("id")]
        public string id { get; set; }

        [JsonPropertyName("userName")]
        public string userName { get; set; }

        [JsonPropertyName("normalizedUserName")]
        public string normalizedUserName { get; set; }

        [JsonPropertyName("email")]
        public string email { get; set; }

        [JsonPropertyName("normalizedEmail")]
        public string normalizedEmail { get; set; }

        [JsonPropertyName("emailConfirmed")]
        public bool emailConfirmed { get; set; }

        [JsonPropertyName("passwordHash")]
        public string passwordHash { get; set; }

        [JsonPropertyName("securityStamp")]
        public string securityStamp { get; set; }

        [JsonPropertyName("concurrencyStamp")]
        public string concurrencyStamp { get; set; }

        [JsonPropertyName("phoneNumber")]
        public string phoneNumber { get; set; }

        [JsonPropertyName("phoneNumberConfirmed")]
        public bool phoneNumberConfirmed { get; set; }

        [JsonPropertyName("twoFactorEnabled")]
        public bool twoFactorEnabled { get; set; }

        [JsonPropertyName("lockoutEnd")]
        public object lockoutEnd { get; set; }

        [JsonPropertyName("lockoutEnabled")]
        public bool lockoutEnabled { get; set; }

        [JsonPropertyName("accessFailedCount")]
        public int accessFailedCount { get; set; }
    }

    public class Address
    {
        [JsonPropertyName("streetName")]
        public string streetName { get; set; }

        [JsonPropertyName("houseNumber")]
        public int houseNumber { get; set; }

        [JsonPropertyName("apartmentNumber")]
        public int apartmentNumber { get; set; }

        [JsonPropertyName("eirCode")]
        public string eirCode { get; set; }

        [JsonPropertyName("city")]
        public string city { get; set; }

        [JsonPropertyName("country")]
        public Country country { get; set; }

        [JsonPropertyName("countryId")]
        public int countryId { get; set; }

        [JsonPropertyName("name")]
        public object name { get; set; }

        [JsonPropertyName("description")]
        public object description { get; set; }

        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("isActive")]
        public object isActive { get; set; }

        [JsonPropertyName("createdAt")]
        public object createdAt { get; set; }

        [JsonPropertyName("modifiedAt")]
        public object modifiedAt { get; set; }
    }

    public class Country
    {
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("description")]
        public string description { get; set; }

        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("isActive")]
        public bool isActive { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime createdAt { get; set; }

        [JsonPropertyName("modifiedAt")]
        public DateTime modifiedAt { get; set; }
    }

}
