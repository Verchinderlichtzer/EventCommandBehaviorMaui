global using CommunityToolkit.Maui;
global using EventCommandBehaviorMaui.Views;
global using Microsoft.Extensions.Logging;
global using EventCommandBehaviorMaui.ViewModels;
global using CommunityToolkit.Mvvm.ComponentModel;
global using EventCommandBehaviorMaui.Models;
global using System.Collections.Generic;
global using System.Collections.ObjectModel;

namespace EventCommandBehaviorMaui;
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

		builder.Services.AddSingletonWithShellRoute<PersonView, PersonViewModel>(nameof(PersonView));

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
