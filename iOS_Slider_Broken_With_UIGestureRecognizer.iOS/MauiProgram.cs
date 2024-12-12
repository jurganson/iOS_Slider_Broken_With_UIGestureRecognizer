namespace iOS_Slider_Broken_With_UIGestureRecognizer.iOS;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();

		builder
			.UseSharedMauiApp();

		builder.ConfigureMauiHandlers(handlers => handlers.AddHandler(typeof(ContentView), typeof(CustomContentViewHandler)));

		return builder.Build();
	}
}
