using MauiShares.Services;
using MauiShares.ViewModels;
using MauiShares.Views;
using Microsoft.Extensions.Logging;
using SkiaSharp.Views.Maui.Controls.Hosting;

namespace MauiShares
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseSkiaSharp()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddTransient<DashboardView>();
            builder.Services.AddTransient<DashboardViewModel>();

            builder.Services.AddTransient<FileDetailsView>();
            builder.Services.AddTransient<FileDetailsViewModel>();

            builder.Services.AddSingleton<FileUploadService>();


#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
