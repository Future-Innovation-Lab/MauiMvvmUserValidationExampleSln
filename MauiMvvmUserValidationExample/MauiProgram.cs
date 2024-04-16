using CommunityToolkit.Maui;
using MauiMvvmUserValidationExample.Interfaces;
using MauiMvvmUserValidationExample.Services;
using MauiMvvmUserValidationExample.ViewModels;
using Microsoft.Extensions.Logging;

namespace MauiMvvmUserValidationExample
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.RegisterServices()
               .RegisterViewModels()
               .RegisterViews();

            return builder.Build();
        }

        public static MauiAppBuilder RegisterServices(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddTransient<IExampleService,ExampleService>();
            mauiAppBuilder.Services.AddTransient<IAlertDialogService, DefaultMauiAlertDialogService>();
            return mauiAppBuilder;
        }

        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<ProfileViewModel>();

            return mauiAppBuilder;
        }

        public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddTransient<ProfileView>();

            return mauiAppBuilder;
        }

    }
}
