
using MobileApp.Services;
using MobileApp.ViewModels.Movie;
using System.Collections.ObjectModel;

namespace MobileApp.Pages.MoviePages;

public partial class MoviesList : ContentPage
{
    private IEnumerable<MovieInfoResponse> allMovies; // Stores full data
    private ObservableCollection<MovieInfoResponse> displayedMovies = new ObservableCollection<MovieInfoResponse>(); // For UI

    public MoviesList()
    {
        InitializeComponent();
        LoadAllMovies();
    }

    private async void LoadAllMovies()
    {
        allMovies = await MovieApiService.GetAllMovies();
        // Populate Genre Picker dynamically (avoid duplicates)
        var genres = allMovies.Select(m => m.Genre).Distinct().ToList();
        genres.Insert(0, "All"); // Add "All" option
        GenrePicker.ItemsSource = genres;

        // Load the initial list
        displayedMovies = new ObservableCollection<MovieInfoResponse>(allMovies);
        CvAllMovies.ItemsSource = displayedMovies;
    }
    private void SortPicker_Changed(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        if (picker.SelectedIndex == -1) return; // No selection

        string selectedSort = picker.Items[picker.SelectedIndex];

        if (selectedSort == "Name (A-Z)")
        {
            displayedMovies = new ObservableCollection<MovieInfoResponse>(displayedMovies.OrderBy(m => m.Title));
        }
        else if (selectedSort == "Name (Z-A)")
        {
            displayedMovies = new ObservableCollection<MovieInfoResponse>(displayedMovies.OrderByDescending(m => m.Title));
        }

        CvAllMovies.ItemsSource = displayedMovies; // Update UI
    }

    private void FilterPicker_Changed(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        if (picker.SelectedIndex == -1) return; // No selection

        string selectedGenre = picker.Items[picker.SelectedIndex];

        if (selectedGenre == "All")
        {
            displayedMovies = new ObservableCollection<MovieInfoResponse>(allMovies);
        }
        else
        {
            displayedMovies = new ObservableCollection<MovieInfoResponse>(allMovies.Where(m => m.Genre == selectedGenre));
        }

        CvAllMovies.ItemsSource = displayedMovies; // Update UI
    }
    private async void OnMovieDetailsClicked(object sender, EventArgs e)
    {
        var button = (Button)sender;
        var movieId = button.CommandParameter;

        if (movieId != null)
        {
            await Navigation.PushAsync(new MovieDetails((int)movieId));
        }
    }
}