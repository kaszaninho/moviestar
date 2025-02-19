using MobileApp.Helpers;
using MobileApp.ViewModels.PaymentMethod;

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
