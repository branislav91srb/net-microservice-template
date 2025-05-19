
@*#if(EnableREST || EnableGrpc)
using Microservice.Template.DependencyInjection.Communication;
#endif*@
@*#if(EnableREST || EnableGrpc)
using Microsoft.AspNetCore.Builder;
#endif*@

using Microservice.Template.DependencyInjection.Infrastructure;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Microservice.Template.DependencyInjection
{
    public static class AppServicesExtension
    {
        public static void AddAppServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAppInfrastructureServices(configuration);
            services.AddPersistence(configuration);
        @*#if(EnableREST)
            services.AddHttpServices();
        #endif*@
        @*#if(EnableGrpc)
            services.AddGrpcServices();
        #endif*@
        }

    @*#if(EnableREST || EnableGrpc)
        public static void UseHttpAppPipeline(this WebApplication app)
        {
        @*#if(EnableREST)
		    app.UseHttpCommunication();
        #endif*@
        @*#if(EnableGrpc)
            app.UseGrpcCommunication();
        #endif*@
        }
    #endif*@
    }
}