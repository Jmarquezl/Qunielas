using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Core;
using Quinieleros.Utils;
using Quinieleros.ViewModels;
using Quinieleros.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quinieleros.IoC
{
    public static class IoC
    {
        public static void AddDependencies(this IServiceCollection service) 
        {
            service.AddTransient<IAlertService, AlertService>();
            service.AddTransient<IRestClient, RestClient>();

            //Views
            service.AddTransient<HomePage>();
            service.AddTransient<BetPage>();
            service.AddTransient<GeneralPage>();
            service.AddSingleton<LoginPage>();
            service.AddTransient<RankPage>();
            service.AddTransient<JornadaPage>();

            //ViewModels
            service.AddTransient<HomeViewModel>();
            service.AddTransient<BetViewModel>();
            service.AddTransient<GeneralViewModel>();
            service.AddSingleton<LoginViewModel>();
            service.AddTransient<RankViewModel>();
            service.AddTransient<JornadaViewModel>();
        }
    }
}
