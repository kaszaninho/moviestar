using BusinessLogic;
using DatabaseAPI.Models.CinemaMovie;
using Stripe.Checkout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalWWW.Helpers
{
    public static class StripeHelper
    {
        public static List<SessionDiscountOptions> CheckCoupon(Coupon coupon)
        {
            switch (coupon.Name)
            {
                case "MOVIE5":
                    return new List<SessionDiscountOptions>
                {
                    new SessionDiscountOptions { Coupon = Constans.Stripe_Coupon_MOVIE5_id }
                };
                case "MOVIE20":
                    return new List<SessionDiscountOptions>
                {
                    new SessionDiscountOptions { Coupon = Constans.Stripe_Coupon_MOVIE20_id }
                };
                default:
                    return new List<SessionDiscountOptions>();
            }
        }
    }
}
