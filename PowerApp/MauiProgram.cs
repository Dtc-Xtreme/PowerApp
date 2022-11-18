using PowerApp.ViewModels;
using PowerApp.Views;

namespace PowerApp;

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


        builder.Services.AddTransient<AppShell>();
        builder.Services.AddTransient<HomePage>();
        builder.Services.AddTransient<HomeViewModel>();
        builder.Services.AddTransient<TipsPage>();
        builder.Services.AddTransient<TipsViewModel>();
        builder.Services.AddTransient<VerbruikPage>();
        builder.Services.AddTransient<VerbruikViewModel>();

        return builder.Build();
	}
}
