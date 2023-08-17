using Authorization.Repository;
using Authorization.Service;
using MongoDB.Driver;
using System.Runtime.CompilerServices;

namespace Authorization.IoC
{
    public static class IoC
    {
        public static IServiceCollection AddDependency(this IServiceCollection services) 
        {
            services.AddTransient<IAuthorizationService, AuthorizationService>();
            services.AddTransient<ICustomMongoClient, CustomMongoClient>();
            services.AddTransient<IAuthorizationRepository, AuthorizationRepository>();
            return services;
        }
    }
}
