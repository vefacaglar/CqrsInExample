using CqrsInExample.Infrastructure.Repositories;
using CqrsInExample.Infrastructure.Repositories.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace CqrsInExample.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IGamesRepository, GamesRepository>();
            return services;
        }
    }
}
