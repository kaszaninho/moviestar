using MobileApp.Services;

namespace MobileApp.Pages;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void BtnSignIn_Clicked(object sender, EventArgs e)
    {
        var response = await IdentityApiService.LoginUser(EntEmail.Text, EntPassword.Text);

        if (response)
        {
            await DisplayAlert("", "Your are logged in", "OK");
            Application.Current.MainPage = new AppShell();
        }
        else
        {
            await DisplayAlert("Login failed", "Something went wrong", "Try again");
        }
    }

    private async void TapRegister_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new RegisterPage());
    }
}