using Microsoft.Extensions.Logging;
using Microsoft.Maui.LifecycleEvents;

namespace MobileApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Arial.ttf", "Arial");
                    fonts.AddFont("Rajdhani-Bold.ttf", "RajdhaniBold");
                    fonts.AddFont("Rajdhani-Light.ttf", "RajdhaniLight");
                    fonts.AddFont("Rajdhani-Medium.ttf", "RajdhaniMedium");
                    fonts.AddFont("Rajdhani-Regular.ttf", "Rajdhani");
                    fonts.AddFont("Rajdhani-SemiBold.ttf", "RajdhaniSemiBold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            return builder.Build();
        }
    }
}
