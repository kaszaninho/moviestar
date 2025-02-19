using MobileApp.Models;
using MobileApp.Services;

namespace MobileApp.Pages.MoviePages
{
    public partial class CouponPage : ContentPage
    {
        private TicketPurchaseState purchaseState;

        public CouponPage(TicketPurchaseState state)
        {
            InitializeComponent();
            purchaseState = state;
            BindingContext = new { OriginalPrice = state.TotalPrice };
        }

        private async void OnApplyCouponClicked(object sender, EventArgs e)
        {
            string couponCode = CouponEntry.Text?.Trim();
            if (string.IsNullOrEmpty(couponCode))
            {
                await DisplayAlert("Error", "Please enter a coupon code", "OK");
                return;
            }

            try
            {
                var coupon = await CouponApiService.ValidateCoupon(couponCode);
                if (coupon == null)
                {
                    await DisplayAlert("Invalid Coupon", "This coupon code is not valid", "OK");
                    return;
                }
                purchaseState.CouponCode = couponCode;
                purchaseState.CouponId = coupon.CouponId;
                purchaseState.DiscountedPrice = purchaseState.TicketsPrice * (coupon.Discount / 100m);
                purchaseState.TotalPrice = purchaseState.TicketsPrice - purchaseState.DiscountedPrice;
                DiscountLabel.Text = $"Discount applied: {coupon.Discount}% off";
                DiscountLabel.IsVisible = true;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void OnContinueClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaymentMethodPage(purchaseState));
        }
    }
}