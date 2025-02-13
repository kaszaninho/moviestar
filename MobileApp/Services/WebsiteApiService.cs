using MobileApp.Helpers;
using MobileApp.ViewModels.AboutUs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
