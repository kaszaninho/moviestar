using MobileApp.Helpers;
using MobileApp.Pages;
using PdfSharp.Fonts;

namespace MobileApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            // needed change to have updated fonts in the MAUI
            GlobalFontSettings.FontResolver = new CustomFontResolver();

            var accesstoken = SecureStorage.GetAsync("accesstoken").GetAwaiter().GetResult();
            if (string.IsNullOrEmpty(accesstoken))
            {
                MainPage = new NavigationPage(new LoginPage());
            }
            else
            {
                MainPage = new AppShell();
            }
        }

        // needed to have customized size of the window.
        protected override Window CreateWindow(IActivationState? activationState)
        {
            const int newHeight = 800;
            const int newWidth = 500;

            var newWindow = new Window(MainPage)
            {
                Height = newHeight,
                Width = newWidth
            };

            return newWindow;
        }
    }
}
