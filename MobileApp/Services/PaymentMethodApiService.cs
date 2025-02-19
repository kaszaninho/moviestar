using MobileApp.Helpers;
using MobileApp.ViewModels.PaymentMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Services
{
    public static class PaymentMethodApiService
    {
        public static async Task<IEnumerable<PaymentMethodResponse>> GetPaymentMethods()
        {
            return await RequestHelper.SendRequestAsync<IEnumerable<PaymentMethodResponse>>($"api/paymentmethod", HttpMethod.Get, null);
        }
    }
}
