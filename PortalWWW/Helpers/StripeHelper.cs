using DatabaseAPI.Models.CinemaMovie;
using HelperProject;
using Stripe.Checkout;

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
