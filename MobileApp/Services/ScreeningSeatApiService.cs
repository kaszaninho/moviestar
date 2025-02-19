using MobileApp.Helpers;
using MobileApp.Models;
using MobileApp.ViewModels.Invoice;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

public static class ScreeningSeatApiService
{
    public static async Task<IEnumerable<ScreeningSeatResponse>> GetSeatsForScreening(int screeningId)
    {
        if (screeningId == 0)
        {
            return new List<ScreeningSeatResponse>();
        }
        return await RequestHelper.SendRequestAsync<IEnumerable<ScreeningSeatResponse>>($"api/screeningseat/getseatsforscreening/{screeningId}", HttpMethod.Get, null);
    }
}