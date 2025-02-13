using MobileApp.Services;

namespace MobileApp.Pages.ProfilePages;

public partial class ProfileUserInfo : ContentPage
{
	public ProfileUserInfo()
	{
		InitializeComponent();
        LoadUserData();
    }

    private async void LoadUserData()
    {
        string? username = await SecureStorage.GetAsync("username");
        var user = await ProfileApiService.GetUser(username);
        UserIdLabel.Text = $"ID: {user.Id}";
        UserNameLabel.Text = $"Username: {user.UserName}";
        EmailLabel.Text = $"Email: {user.Email}";
        PhoneNumberLabel.Text = $"Phone: {user.PhoneNumber}";

        FirstNameLabel.Text = $"First Name: {user.FirstName}";
        MiddleNameLabel.Text = $"Middle Name: {user.MiddleName ?? "N/A"}";
        LastNameLabel.Text = $"Last Name: {user.LastName}";
        DateOfBirthLabel.Text = $"DOB: {user.DateOfBirth:MMM dd, yyyy}";

        StreetLabel.Text = $"Street: {user.Address.Street}";
        EirCodeLabel.Text = $"EirCode: {user.Address.Eircode}";
        CityLabel.Text = $"City: {user.Address.City}";
        CountryLabel.Text = $"Country: {user.Address.Country}";

        EmailConfirmedLabel.Text = $"Email Confirmed: {(user.EmailConfirmed ? "Yes" : "No")}";
        PhoneNumberConfirmedLabel.Text = $"Phone Confirmed: {(user.PhoneNumberConfirmed ? "Yes" : "No")}";
        TwoFactorEnabledLabel.Text = $"2FA Enabled: {(user.TwoFactorEnabled ? "Yes" : "No")}";
    }
}