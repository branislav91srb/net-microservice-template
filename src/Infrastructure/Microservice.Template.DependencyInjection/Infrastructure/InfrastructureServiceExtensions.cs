using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microservice.Template.Application.Services;
using Microservice.Template.Infrastructure.Services;

namespace Microservice.Template.DependencyInjection.Infrastructure
{
    public static class InfrastructureServiceExtensions
    {
        public static void AddAppInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IService, Service>();
        }
    }
}
