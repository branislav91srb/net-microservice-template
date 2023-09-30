
@*#if(EnableREST || EnableGrpc || EnableMessaging)
using Microservice.Template.DependencyInjection.Communication;
#endif*@
@*#if(EnableThirdParty)
using Microservice.Template.DependencyInjection.ThirdParty;
#endif*@
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
        @*#if(EnableThirdParty)
            services.AddAmadeusServices();
         #endif*@
        @*#if(EnableMessaging)
            services.AddRabbitMq();
        #endif*@
        @*#if(EnableREST)
            services.AddHttpServices();
        #endif*@
        @*#if(EnableGrpc)
            services.AddGrpcServices();
        #endif*@
        }

        public static void UseHttpAppPipeline(this WebApplication app)
        {
        @*#if(EnableREST)
		    app.UseHttpCommunication();
        #endif*@
        @*#if(EnableGrpc)
            app.UseGrpcCommunication();
        #endif*@
        }
    }
}