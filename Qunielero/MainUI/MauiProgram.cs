using CommunityToolkit.Maui;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Quinieleros.IoC;
using System.Reflection;

namespace Quinieleros
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
            builder.Services.AddDependencies();

            string configScope = "Quinieleros.appsetting.release.json";
#if DEBUG
            configScope = "Quinieleros.appsettings.debug.json";
		builder.Logging.AddDebug();
#endif
            var assembly = Assembly.GetExecutingAssembly();
            using var stream = assembly.GetManifestResourceStream(configScope);
            var config = new ConfigurationBuilder()
                .AddJsonStream(stream).Build();

            builder.Configuration.AddConfiguration(config);
            
            return builder.Build();
        }
    }
}