using Microsoft.Extensions.Logging;
using NavigationServiceMAUI.Services;
using NavigationServiceMAUI.ViewModels;
using NavigationServiceMAUI.Views;

namespace NavigationServiceMAUI;

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
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<INavigationService, NavigationService>();

		// UI registration
		builder.Services.AddSingleton<AppLaunchPage>();
        builder.Services.AddTransient<StudentListPage>();
        builder.Services.AddTransient<StudentDetailPage>();




        //viewmodel registration
        builder.Services.AddSingleton<AppLaunchPageViewModel>();
        builder.Services.AddTransient<StudentListPageViewModel>();
        builder.Services.AddTransient<StudentDetailPageViewModel>();


        return builder.Build();
	}
}
