using MobileApp.Helpers;
using MobileApp.ViewModels.Invoice;

namespace MobileApp.Services
{
    public static class TicketApiService
    {
        public static async Task<IEnumerable<TicketResponse>> GetScreeningsForUser(string userId)
        {
            return await RequestHelper.SendRequestAsync<IEnumerable<TicketResponse>>("api/ticket/ticketsforuser/" + userId, HttpMethod.Get, null);
        }
    }
}
