using Microsoft.Extensions.DependencyInjection;
using OutOfLife.Repositories.DataEstructure;
using OutOfLife.Repositories.DataRepositories.Acess;
using OutOfLife.Repositories.DataRepositories.Acess.Interfaces;
using OutOfLife.Services.Persistence.Acess;
using OutOfLife.Services.Persistence.Acess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OutOfLife.Api.Config.Injection
{
    public static class InjectionConfigMidleware
    {
        public static IServiceCollection ConfigInjectOutOfLife(this IServiceCollection Services)
        {
            return Services.ConfigDataContext()
                           .ConfigAcessLayer();
        }

        private static IServiceCollection ConfigAcessLayer(this IServiceCollection Services)
        {
            return Services.AddTransient<IUserRepository, UserRepository>()
                           .AddTransient<IUserService, UserService>();
        }

        private static IServiceCollection ConfigDataContext(this IServiceCollection Services)
        {
            return Services.AddTransient<DataContext>();
        }
    }
}
