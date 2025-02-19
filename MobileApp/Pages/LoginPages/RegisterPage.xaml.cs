using MobileApp.Services;
using MobileApp.ViewModels.Identity;
using System.Collections.ObjectModel;
using static MobileApp.Services.AppSettings;

namespace MobileApp.Pages;

public partial class RegisterPage : ContentPage
{
    private int selectedCountryId = 0;
    private ObservableCollection<CountryResponse> countries = new ObservableCollection<CountryResponse>();
    public RegisterPage()
    {
        InitializeComponent();
        ImageLabel.Source = IMAGE_LOGO_URL;
        LoadCountries();
    }

    private async void LoadCountries()
    {
        countries = new ObservableCollection<CountryResponse>(await IdentityApiService.GetCountryList());
        foreach (var country in countries)
        {
            PickerCountry.Items.Add(country.CountryName);
        }
    }
    private void PickerCountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (PickerCountry.SelectedIndex != -1)
        {
            selectedCountryId = countries.ElementAt(PickerCountry.SelectedIndex).CountryId;
        }
    }
    private async void BtnRegister_Clicked(object sender, EventArgs e)
    {
        if (EntConfirmPassword.Text != EntPassword.Text)
        {
            await DisplayAlert("Error", "Passwords do not match.", "OK");
            return;
        }

        var registerRequest = new RegisterRequest
        {
            Email = EntEmail.Text,
            Password = EntPassword.Text,
            FirstName = EntFirstName.Text,
            MiddleName = EntMiddleName.Text,
            LastName = EntLastName.Text,
            DateOfBirth = DpDateOfBirth.Date.ToString("yyyy-MM-dd"),
            StreetName = EntStreetName.Text,
            HouseNumber = int.Parse(EntHouseNumber.Text),
            ApartmentNumber = int.Parse(EntApartmentNumber.Text),
            EirCode = EntEirCode.Text,
            City = EntCity.Text,
            CountryId = selectedCountryId
        };
        var response = await IdentityApiService.RegisterUser(registerRequest);

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