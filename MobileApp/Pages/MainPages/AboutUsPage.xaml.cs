using MobileApp.Pages.AboutUs;
using MobileApp.Services;
using MobileApp.ViewModels.AboutUs;

namespace MobileApp.Pages;

public partial class AboutUsPage : ContentPage
{
    private IEnumerable<WebsiteResponse> WebsitePages { get; set; } = new List<WebsiteResponse>();
    public AboutUsPage()
    {
        InitializeComponent();
        LoadWebsites();
    }

    private async void LoadWebsites()
    {
        WebsitePages = await WebsiteApiService.GetWebsiteLists();
        CvAllWebsites.ItemsSource = WebsitePages;
    }

    private async void OnWebsiteClicked(object sender, EventArgs e)
    {
        if (sender is Button button)
        {
            var websiteId = (int)button.CommandParameter;
            var website = WebsitePages.First(x => x.Id == websiteId);
            var navParams = new Dictionary<string, object>
            {
                { "WebsiteData", website }
            };

            await Navigation.PushAsync(new WebsiteDetailPage(website));
        }
    }
}