using MobileApp.Helpers;
using MobileApp.Models;
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

        public static async Task<bool> CompleteTransaction(TicketPurchaseState purchaseState, string userId)
        {
            if (purchaseState == null || userId == null)
            {
                return false;
            }
            var requestBody = new InvoiceTransactionCreateRequest
            {
                CouponDiscount = purchaseState.DiscountedPrice,
                CouponId = purchaseState.CouponId,
                InvoiceId = Guid.NewGuid(),
                PaymentMethodId = purchaseState.PaymentMethodId,
                TicketSum = purchaseState.TicketsPrice,
                TotalSum = purchaseState.TotalPrice,
                UserId = userId,
                ScreeningSeatIds = purchaseState.SelectedSeatIds
            };
            return await RequestHelper.SendRequestAsync($"api/invoice", HttpMethod.Post, requestBody, null);
        }
    }
}
