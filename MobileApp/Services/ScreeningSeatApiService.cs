using MobileApp.Helpers;

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