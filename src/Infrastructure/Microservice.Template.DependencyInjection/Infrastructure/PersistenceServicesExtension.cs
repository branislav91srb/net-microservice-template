using Microservice.Template.Application.Repositories;
using Microservice.Template.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace Microservice.Template.DependencyInjection.Infrastructure
{
    public static class PersistenceServicesExtension
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IRepository, ToDoRepository>();
        }
    }
}
