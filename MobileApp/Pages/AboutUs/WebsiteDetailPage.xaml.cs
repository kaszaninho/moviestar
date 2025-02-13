using MobileApp.ViewModels.AboutUs;

namespace MobileApp.Pages.AboutUs;


public partial class WebsiteDetailPage : ContentPage
{
    private WebsiteResponse websiteData;

    public WebsiteDetailPage(WebsiteResponse? website)
    {
        InitializeComponent();
        websiteData = website;
        LoadWebsiteData();
    }

    private void LoadWebsiteData()
    {
        TitleNameLabel.Text = websiteData.TitleName;
        ContentHtmlWebView.Source = new HtmlWebViewSource
        {
            Html = websiteData.Content
        };
    }
}