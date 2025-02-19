using System.Text.Json.Serialization;

namespace MobileApp.ViewModels.Identity
{
    public class LoginResponse
    {
        [JsonPropertyName("tokenType")]
        public string TokenType { get; set; } = null!;
        [JsonPropertyName("accessToken")]
        public string AccessToken { get; set; } = null!;
        [JsonPropertyName("expiresIn")]
        public int ExpiresIn { get; set; }
        [JsonPropertyName("refreshToken")]
        public string RefreshToken { get; set; } = null!;
    }
}
