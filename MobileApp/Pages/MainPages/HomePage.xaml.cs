
using MobileApp.Services;
using System.Xml.Linq;

namespace MobileApp.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
		LoadData().GetAwaiter().GetResult();
	}

    private async Task LoadData()
    {
		GetUserProfile().GetAwaiter().OnCompleted(GetMovieAllInfo);
    }

    private async void GetMovieAllInfo()
    {
		var userId = await SecureStorage.GetAsync("userid");
		var movieListViewModel = await MovieApiService.GetMovieAllInfo(userId);
		CvUpcomingScreenings.ItemsSource = movieListViewModel.EarliestScreeningsWithMovies;

        InvoiceNumber.Text = movieListViewModel.LatestInvoiceWithTickets.InvoiceId.ToString();
        InvoiceDate.Text = movieListViewModel.LatestInvoiceWithTickets.CreatedAt.ToShortDateString();
        InvoiceAmount.Text = $"PLN {movieListViewModel.LatestInvoiceWithTickets.TotalSum:F2}";
        InvoiceOrderStatus.Text = movieListViewModel.LatestInvoiceWithTickets.OrderStatus;
        InvoicePaymentStatus.Text = movieListViewModel.LatestInvoiceWithTickets.PaymentStatus;
        ButtonInvoiceDetails.CommandParameter = movieListViewModel.LatestInvoiceWithTickets.InvoiceId;
    }


    private async Task GetUserProfile()
    {
		var name = await SecureStorage.GetAsync("name");

        if (name == null)
		{
			var param = await SecureStorage.GetAsync("username") ?? await SecureStorage.GetAsync("userid");
			if (param == null)
			{
				return;
			}
			var response = await ProfileApiService.GetUser(param);
			if (response == null)
			{
				SecureStorage.RemoveAll();
                Application.Current.MainPage = new NavigationPage(new LoginPage());
            }
			else 
			{ 
                name = response.FirstName;
                await SecureStorage.SetAsync("name", name);
                LblUserName.Text = "Hi " + name;
            }
		}
		else
		{
            LblUserName.Text = "Hi " + name;
        }
    }
    private void OnMovieTapped(object sender, TappedEventArgs e)
    {
        int movieId = Convert.ToInt32(e.Parameter);
        LblUserName.Text = "You tapped movie " + movieId;
    }

    private void InvoiceDetails_Clicked(object sender, TappedEventArgs e)
    {
        LblUserName.Text = "You tapped details " + Convert.ToString(e.Parameter);
    }
}