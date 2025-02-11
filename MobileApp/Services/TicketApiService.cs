using MobileApp.Helpers;
using MobileApp.ViewModels.Invoice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
