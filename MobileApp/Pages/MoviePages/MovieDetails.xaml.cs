using MobileApp.Services;
using MobileApp.ViewModels.Movie;
using System.Collections.ObjectModel;

namespace MobileApp.Pages.MoviePages;

public partial class MovieDetails : ContentPage
{
    private int _movieId;
    public MovieDetails(int movieId)
    {
        InitializeComponent();
        _movieId = movieId;
        LoadMovieDetails();
    }

    private async void LoadMovieDetails()
    {
        var movie = await MovieApiService.GetMovie(_movieId);
        MovieTitle.Text = movie.Title;
        MovieGenre.Text = $"Genre: {movie.Genre}";
        MovieFormat.Text = $"Format: {movie.MovieFormat}";
        MovieDuration.Text = $"Duration: {movie.Duration} min";
        MovieReleaseDate.Text = $"Release Date: {movie.ReleaseDate:MMM dd, yyyy}";
        MovieAgeRating.Text = $"Age Rating: {movie.AgeRating}";
        MovieCountry.Text = $"Country: {movie.Country}";
        MovieProductionCompany.Text = $"Production: {movie.MovieProductionCompany}";
        MovieTicketPrice.Text = $"Ticket Price: PLN {movie.TicketPrice:F2}";
        MovieDescription.Text = movie.Description;
        MovieImage.Source = movie.FullImageUrl;

        // Load screenings
        if (movie.Screenings != null && movie.Screenings.Count > 0)
        {
            ScreeningsCollectionView.ItemsSource = new ObservableCollection<MiniScreeningResponse>(movie.Screenings);
        }
        else
        {
            ScreeningsCollectionView.ItemsSource = new ObservableCollection<MiniScreeningResponse>();
        }
    }

    private async void BtnBuyTickets_Clicked(object sender, EventArgs e)
    {
        if (sender is Button button && button.CommandParameter is int screeningId)
        {
            await Navigation.PushAsync(new SeatSelectionPage(screeningId));
        }
    }
}