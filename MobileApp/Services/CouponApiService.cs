using MobileApp.Helpers;
using MobileApp.ViewModels.Coupon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Services
{
    public static class CouponApiService
    {

        public static async Task<CouponResponse> ValidateCoupon(string couponName)
        {
            try
            {
                return await RequestHelper.SendRequestAsync<CouponResponse>($"api/coupon/{couponName}", HttpMethod.Get, null);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
