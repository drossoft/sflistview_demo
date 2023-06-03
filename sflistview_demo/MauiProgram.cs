using Syncfusion.Maui.Core.Hosting;

namespace sflistview_demo;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
            .ConfigureSyncfusionCore()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<Page1ViewModel>();

		builder.Services.AddSingleton<Page1Page>();

		builder.Services.AddSingleton<Page2ViewModel>();

		builder.Services.AddSingleton<Page2Page>();

		return builder.Build();
	}
}
