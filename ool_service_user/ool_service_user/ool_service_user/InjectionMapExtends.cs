using Microsoft.Extensions.DependencyInjection;
using ool_service_user.Repositories;
using ool_service_user.Repositories.Interfaces;
using ool_service_user.Services;
using ool_service_user.Services.Interfaces;

namespace ool_service_user
{
    public static class InjectionMapExtends
    {
        public static IServiceCollection InjectionMap(this IServiceCollection Services)
        {
            return Services.AddTransient<IMongoAcess, MongoAcess>()
                           .AddTransient<IUserRepository, UserRepository>()
                           .AddTransient<IUserService, UserService>();
        }
    }
}
