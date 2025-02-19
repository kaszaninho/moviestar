using MobileApp.Helpers;
using MobileApp.ViewModels.AboutUs;

namespace MobileApp.Services
{
    public static class WebsiteApiService
    {
        public static async Task<IEnumerable<WebsiteResponse>> GetWebsiteLists()
        {
            return await RequestHelper.SendRequestAsync<IEnumerable<WebsiteResponse>>("/api/Website", HttpMethod.Get, null);
        }
    }
}
