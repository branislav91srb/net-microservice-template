using Microservice.Template.DependencyInjection.Communication;
using Microservice.Template.DependencyInjection.ThirdParty;
using Microservice.Template.DependencyInjection.Infrastructure;
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

        @*#if(MessageBroker)
            services.AddRabbitMq();
        #endif*@
        @*#if(REST)
            services.AddHttpServices();
        #endif*@
        @*#if(gRPC)
            services.AddGrpcServices();
        #endif*@
        }

        public static void UseHttpAppPipeline(this WebApplication app)
        {
        @*#if(REST)
		    app.UseHttpCommunication();
        #endif*@
        @*#if(gRPC)
            app.UseGrpcCommunication();
        #endif*@
        }
    }
}