using MobileApp.Helpers;
using MobileApp.ViewModels.Identity;

namespace MobileApp.Services
{
    public class IdentityApiService
    {
        public static async Task<bool> RegisterUser(RegisterRequest registerRequest)
        {
            return await RequestHelper.SendRequestAsync("/register", HttpMethod.Post, registerRequest, null);
        }

        public static async Task<bool> LoginUser(string email, string password)
        {
            var login = new LoginRequest()
            {
                Email = email,
                Password = password
            };
            var response = await RequestHelper.SendRequestAsync<LoginRequest, LoginResponse>("/login", HttpMethod.Post, login, null);
            if (response == null)
            {
                return false;
            }
            await SecureStorage.SetAsync("accesstoken", response.AccessToken);
            await SecureStorage.SetAsync("username", email);
            return true;
        }

        public static async Task<IEnumerable<CountryResponse>> GetCountryList()
        {
            return await RequestHelper.SendRequestAsync<IEnumerable<CountryResponse>>("/api/Country", HttpMethod.Get, null);
        }
    }
}
