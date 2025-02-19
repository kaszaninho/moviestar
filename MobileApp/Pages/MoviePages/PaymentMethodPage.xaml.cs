using MobileApp.Models;
using MobileApp.Services;

namespace MobileApp.Pages.MoviePages
{
    public partial class PaymentMethodPage : ContentPage
    {
        private readonly TicketPurchaseState purchaseState;

        public PaymentMethodPage(TicketPurchaseState state)
        {
            InitializeComponent();
            purchaseState = state;
            BindingContext = new { FinalPrice = state.TotalPrice };
            LoadPaymentMethods();
        }
        private async void LoadPaymentMethods()
        {
            try
            {
                var paymentMethods = await PaymentMethodApiService.GetPaymentMethods();
                foreach (var method in paymentMethods)
                {
                    var radioButton = new RadioButton
                    {
                        Content = method.MethodName,
                        GroupName = "payment",
                        Value = method.MethodId,
                        TextColor = Colors.White
                    };
                    radioButton.CheckedChanged += OnPaymentMethodChanged;
                    PaymentMethodsContainer.Children.Add(radioButton);
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", "Failed to load payment methods: " + ex.Message, "OK");
            }
        }

        private void OnPaymentMethodChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value && sender is RadioButton rb)
            {
                purchaseState.PaymentMethod = rb.Content as string;
                purchaseState.PaymentMethodId = (int?)rb.Value;
                CompleteButton.IsEnabled = true;
            }
        }


        private async void OnCompletePurchaseClicked(object sender, EventArgs e)
        {
            try
            {
                var userId = await SecureStorage.GetAsync("userid");
                var success = await InvoiceApiService.CompleteTransaction(purchaseState, userId);

                if (success)
                {
                    await DisplayAlert("Success", "Tickets purchased successfully!", "OK");
                    // Navigate back to the main page or show tickets
                    await Navigation.PopToRootAsync();
                }
                else
                {
                    await DisplayAlert("Error", "Failed to purchase tickets", "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}