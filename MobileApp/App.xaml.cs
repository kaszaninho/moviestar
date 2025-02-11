using MobileApp.Pages;

namespace MobileApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

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
        protected override Window CreateWindow(IActivationState? activationState)
        {
            const int newHeight = 800;
            const int newWidth = 450;

            var newWindow = new Window(MainPage)
            {
                Height = newHeight,
                Width = newWidth
            };

            return newWindow;
        }
    }
}
