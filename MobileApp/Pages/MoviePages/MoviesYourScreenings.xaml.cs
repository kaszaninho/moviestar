using MobileApp.Services;
using MobileApp.ViewModels.Movie;
using System.Collections.ObjectModel;

namespace MobileApp.Pages.MoviePages;

public partial class MoviesYourScreenings : ContentPage
{
    private IEnumerable<Screening> allScreenings; // Stores full data
    private ObservableCollection<Screening> displayedScreenings = new ObservableCollection<Screening>(); // For UI
    public MoviesYourScreenings()
	{
		InitializeComponent();
		LoadScreeningsData();
	}

	private async void LoadScreeningsData()
	{
        var userId = await SecureStorage.GetAsync("userid");
		if (userId != null)
		{
            allScreenings = await MovieApiService.GetScreeningsForUser(userId);
            displayedScreenings = new ObservableCollection<Screening>(allScreenings);
            CvAllScreenings.ItemsSource = displayedScreenings;

        }
    }
    private void SortPicker_Changed(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        if (picker.SelectedIndex == -1) return; // No selection

        string selectedSort = picker.Items[picker.SelectedIndex];

        if (selectedSort == "Earliest Start Date")
        {
            displayedScreenings = new ObservableCollection<Screening>(displayedScreenings.OrderBy(m => m.StartDate));
        }
        else if (selectedSort == "Latest Start Date")
        {
            displayedScreenings = new ObservableCollection<Screening>(displayedScreenings.OrderByDescending(m => m.StartDate));
        }
        else
        {
            displayedScreenings = new ObservableCollection<Screening>(displayedScreenings.Order());
        }

        CvAllScreenings.ItemsSource = displayedScreenings; // Update UI
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