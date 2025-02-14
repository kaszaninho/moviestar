using MobileApp.Pages.AboutUs;
using MobileApp.Services;
using MobileApp.ViewModels.AboutUs;
using System.Collections.ObjectModel;
using static MobileApp.Services.AppSettings;

namespace MobileApp.Pages;

public partial class AboutUsPage : ContentPage
{
    private IEnumerable<WebsiteResponse> WebsitePages { get; set; } = new List<WebsiteResponse>();
    private ObservableCollection<WebsiteResponse> DisplayedPages { get; set; } = new ObservableCollection<WebsiteResponse>();
    public AboutUsPage()
    {
        InitializeComponent();
        ImageLabel.Source = IMAGE_LOGO_URL;
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
            var websiteId = (int) button.CommandParameter;
            var website = WebsitePages.First(x => x.Id == websiteId);
            var navParams = new Dictionary<string, object>
            {
                { "WebsiteData", website }
            };

            await Navigation.PushAsync(new WebsiteDetailPage(website));
        }
    }
}