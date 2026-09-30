using Microsoft.AspNetCore.Components.WebView.Maui;
using WarrentyTracker1._0.Data;
using WarrentyTracker1._0.Services;
using Microsoft.Extensions.Logging;
using FirebaseAdmin;
using Firebase.Auth.Providers;
using Google.Apis.Auth.OAuth2;
using Firebase.Auth;
using Firebase.Auth.Repository;
using Firebase.Database;


namespace WarrentyTracker1._0;

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
			});

		builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		/*builder.Logging.AddDebug();*/


#endif
		builder.Services.AddScoped<StateContainer>();
		builder.Services.AddSingleton<IAppService, AppService>();
		builder.Services.AddSingleton<WeatherForecastService>();

		//In production enviroment we wouldnt expose credential to repo 
		string workDirectory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"../../../../../"));
		string configDirectory = Path.Combine(workDirectory, "ServiceAccount.json");
		FirebaseApp.Create(new AppOptions()
		{
			Credential = GoogleCredential.FromFile(configDirectory)	
		});

		//Firebase Database Configuration
		var Dconfig = new FirebaseClient("https://mywarranties-7e52e-default-rtdb.europe-west1.firebasedatabase.app/");
		FirebaseOptions options = new FirebaseOptions
		{
			
		};

        return builder.Build();
	}
}
