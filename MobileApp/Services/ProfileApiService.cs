using MobileApp.Helpers;
using MobileApp.ViewModels.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Services
{
    public static class ProfileApiService
    {
        public static async Task<UserResponse> GetUser(string email)
        {
            var response = await RequestHelper.SendRequestAsync<UserResponse>("/api/user/" + email, HttpMethod.Get, null);
            if (response == null) return null;
            await SecureStorage.SetAsync("userid", response.Id);
            await SecureStorage.SetAsync("username", email);
            return response;
        }
    }
}
