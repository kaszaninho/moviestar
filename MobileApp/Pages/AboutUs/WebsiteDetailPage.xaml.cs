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
        string styledHtml = $@"
    <html>
    <head>
        <style>
            body {{
                background-color: black;
                color: white;
            }}
            a {{
                color: lightblue;
            }}
        </style>
    </head>
    <body>
        {websiteData.Content}
    </body>
    </html>";
        ContentHtmlWebView.Source = new HtmlWebViewSource
        {
            Html = styledHtml
        };
    }
}