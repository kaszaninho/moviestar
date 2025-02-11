using MobileApp.Pages.MoviePages;

namespace MobileApp.Pages;

public partial class MoviesPage : ContentPage
{
	public MoviesPage()
	{
		InitializeComponent();
	}

    private async void BtnMoviesList_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MoviesList());
    }

    private async void BtnYourScreenings_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MoviesYourScreenings());
    }
}