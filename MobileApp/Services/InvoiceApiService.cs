using MobileApp.Helpers;
using MobileApp.ViewModels.Invoice;
using MobileApp.ViewModels.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Services
{
    public static class InvoiceApiService
    {
        public static async Task<IEnumerable<Invoice>> GetInvoiceListForUser(string userId)
        {
            return await RequestHelper.SendRequestAsync<IEnumerable<Invoice>>("api/invoice/invoicesforuser/" + userId, HttpMethod.Get, null);
        }
        public static async Task<InvoiceResponse> GetInvoice(string invoiceId)
        {
            return await RequestHelper.SendRequestAsync<InvoiceResponse>("api/Invoice/" + invoiceId, HttpMethod.Get, null);
        }
    }
}
