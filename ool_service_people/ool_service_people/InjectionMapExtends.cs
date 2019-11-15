using Microsoft.Extensions.DependencyInjection;
using ool_service_people.Repositories;
using ool_service_people.Repositories.Interfaces;
using ool_service_people.Services;
using ool_service_people.Services.Interfaces;

namespace ool_service_user
{
    public static class InjectionMapExtends
    {
        public static IServiceCollection InjectionMap(this IServiceCollection Services)
        {
            return Services.AddTransient<IMongoAcess, MongoAcess>()
                           .AddTransient<IPeopleRepository, PeopleRepository>()
                           .AddTransient<IPeoplePersistenceService, PeoplePersistenceService>();
        }
    }
}
