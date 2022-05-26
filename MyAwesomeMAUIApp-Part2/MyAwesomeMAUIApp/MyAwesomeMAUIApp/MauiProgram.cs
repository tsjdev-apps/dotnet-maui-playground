using MyAwesomeMAUIApp.Services;
using MyAwesomeMAUIApp.ViewModels;

namespace MyAwesomeMAUIApp;

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

		builder.Services.AddTransient<MainPage>();
		builder.Services.AddTransient<MainPageViewModel>();

		builder.Services.AddSingleton<IDialogService, DialogService>();

		builder.Services.AddSingleton(AppInfo.Current);

		return builder.Build();
	}
}
