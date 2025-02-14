using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MobileApp.ViewModels.Identity
{
    public class LoginRequest
    {
        [JsonPropertyName("email")]
        public string Email { get; set; } = null!;

        [JsonPropertyName("password")]
        public string Password { get; set; } = null!;
    }
}
