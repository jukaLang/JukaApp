namespace JukaApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts => {
				fonts.AddFont("CONSOLA.TTF", "CONSOLA");
				fonts.AddFont("Poppins-Bold.ttf", "Poppins");
                fonts.AddFont("ShiningHoovesRegular.ttf", "SHR");
                fonts.AddFont("Architex.ttf", "Architex");
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		return builder.Build();
	}
}
