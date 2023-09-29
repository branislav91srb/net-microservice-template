using Microservice.Template.DependencyInjection.Communication;
using Microservice.Template.DependencyInjection.ThirdParty;
using Microservice.Template.DependencyInjection.Utility;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Microservice.Template.DependencyInjection
{
    public static class AppServicesExtension
    {
        public static void AddAppServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddPersistance();
            services.AddAmadeusServices();
            services.AddRabbitMq();
            services.AddHttpServices();
            services.AddGrpcServices();
        }

        public static void UseHttpAppPipeline(this WebApplication app)
        {
            app.UseHttpCommunication();
            app.UseGrpcCommunication();
        }
    }
}