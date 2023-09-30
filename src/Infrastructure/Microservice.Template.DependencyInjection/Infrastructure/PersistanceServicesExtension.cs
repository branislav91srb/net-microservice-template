using Microservice.Template.Application.Repositories;
using Microservice.Template.Persistence.DbContexts;
using Microservice.Template.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Microservice.Template.DependencyInjection.Infrastructure
{
    public static class PersistanceServicesExtension
    {
        public static void AddPersistance(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>();

            services.AddScoped<IFlightRepository, FlightRepository>();
        }
    }
}
