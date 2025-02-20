using MobileApp.Pages.MoviePages;
using MobileApp.Pages.ProfilePages;
using MobileApp.Services;
using static MobileApp.Services.AppSettings;

namespace MobileApp.Pages;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
        ImageLabel.Source = IMAGE_LOGO_URL;
        LoadData().GetAwaiter().GetResult();
    }

    private async Task LoadData()
    {
        GetUserProfile().GetAwaiter().OnCompleted(GetMovieAllInfo);
    }

    private async void GetMovieAllInfo()
    {
        try
        {
            var userId = await SecureStorage.GetAsync("userid");
            if (userId != null)
            {
                var movieListViewModel = await MovieApiService.GetMovieAllInfo(userId);
                if (movieListViewModel != null)
                {
                    CvUpcomingScreenings.ItemsSource = movieListViewModel.EarliestScreeningsWithMovies;

                    InvoiceNumber.Text = movieListViewModel.LatestInvoiceWithTickets.InvoiceId.ToString();
                    InvoiceDate.Text = movieListViewModel.LatestInvoiceWithTickets.CreatedAt.ToShortDateString();
                    InvoiceAmount.Text = $"PLN {movieListViewModel.LatestInvoiceWithTickets.TotalSum:F2}";
                    InvoiceOrderStatus.Text = movieListViewModel.LatestInvoiceWithTickets.OrderStatus;
                    InvoicePaymentStatus.Text = movieListViewModel.LatestInvoiceWithTickets.PaymentStatus;
                    // Set CommandParameter in code
                    ButtonInvoiceDetails.CommandParameter = movieListViewModel.LatestInvoiceWithTickets.InvoiceId;
                }
            }
        }
        catch (Exception)
        {
            await DisplayAlert("Error", $"Error when loading Movie/Invoice information.", "OK");
        }

    }

    private async Task GetUserProfile()
    {
        try
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
        catch (Exception)
        {
            await DisplayAlert("Error", $"Error when fetching user information.", "OK");
        }
    }

    private async void OnMovieTapped(object sender, TappedEventArgs e)
    {
        int movieId = Convert.ToInt32(e.Parameter);

        if (movieId != null)
        {
            await Navigation.PushAsync(new MovieDetails(movieId));
        }
    }

    private async void InvoiceDetails_Clicked(object sender, EventArgs e)
    {
        if (sender is Button button)
        {
            var invoiceId = ((Guid)button.CommandParameter).ToString();
            if (invoiceId != null)
            {
                await Navigation.PushAsync(new InvoiceDetails(invoiceId));
            }
        }
    }
}