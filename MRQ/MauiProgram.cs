using Microsoft.Extensions.Logging;
using Microcharts.Maui;
using MRQ.Pages;
using MRQ.ViewModels;
using MRQ.Services;


namespace MRQ
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMicrocharts()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Roboto-Regular.ttf", "Roboto");
                    fonts.AddFont("Roboto-Bold.ttf", "RobotoBold");
                });
            // Register Interfaces for DI
            builder.Services.AddSingleton<INavigationService, NavigationService>();
            // ViewModel DI

            // Register your pages and view models
            builder.Services.AddSingleton<DietTypePage>();
            builder.Services.AddSingleton<DietTypeViewModel>();
            builder.Services.AddSingleton<SustainableCommutePage>();
            builder.Services.AddSingleton<SustainableCommuteViewModel>();
            builder.Services.AddSingleton<FlightHoursPage>();
            builder.Services.AddSingleton<FlightHoursViewModel>();
            // Register your navigation routes
            Routing.RegisterRoute(nameof(SustainableCommutePage), typeof(SustainableCommutePage));
            Routing.RegisterRoute(nameof(FlightHoursPage), typeof(FlightHoursPage));

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
