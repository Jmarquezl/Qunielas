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
            //Views
            service.AddSingleton<BetPage>();
            service.AddSingleton<GeneralPage>();
            service.AddSingleton<LoginPage>();
            service.AddSingleton<RankPage>();

            //ViewModels
            service.AddSingleton<BetViewModel>();
            service.AddSingleton<GeneralViewModel>();
            service.AddSingleton<LoginViewModel>();
            service.AddSingleton<RankViewModel>();
        }
    }
}
