using MobileApp.Services;
using static MobileApp.Services.AppSettings;
namespace MobileApp.Pages;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
        ImageLabel.Source = IMAGE_LOGO_URL;
    }

    private async void BtnSignIn_Clicked(object sender, EventArgs e)
    {
        try
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
        catch (UnauthorizedAccessException ex)
        {
            await DisplayAlert("Login failed", "Wrong credentials", "Try again");
        }
    }

    private async void TapRegister_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new RegisterPage());
    }
}