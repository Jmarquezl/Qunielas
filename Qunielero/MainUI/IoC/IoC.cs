using Quinieleros.Utils;
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
        }
    }
}
