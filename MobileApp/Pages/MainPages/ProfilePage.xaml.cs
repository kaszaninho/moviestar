using MobileApp.Pages.ProfilePages;

namespace MobileApp.Pages;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();
	}

	private void Logout_Clicked(object sender, EventArgs e)
	{
        SecureStorage.RemoveAll();
        Application.Current.MainPage = new NavigationPage(new LoginPage());
    }

    private async void BtnInvoiceInfo_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ProfileInvoices());
    }

    private async void BtnTicketInfo_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ProfileTickets());
    }
}