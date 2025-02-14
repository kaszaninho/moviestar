using MobileApp.Services;
using static MobileApp.Services.AppSettings;

namespace MobileApp.Pages;

public partial class RegisterPage : ContentPage
{
    public RegisterPage()
    {
        InitializeComponent();
        ImageLabel.Source = IMAGE_LOGO_URL;
    }

    private async void BtnRegister_Clicked(object sender, EventArgs e)
    {
        var response = await IdentityApiService.RegisterUser(EntEmail.Text, EntPassword.Text);

        if (response)
        {
            await SecureStorage.SetAsync("hasAuth", "true");
            await DisplayAlert("", "Registration complete. Moving to log in page", "OK");
            await Navigation.PushAsync(new LoginPage());
        }
        else
        {
            await DisplayAlert("Registration failed", "Something went wrong", "Try again");
        }
    }

    private async void TapSignIn_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }
}