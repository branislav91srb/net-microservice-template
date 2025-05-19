using FastEndpoints;
using FastEndpoints.Swagger;
using Microservice.Template.Communication.Rest;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Microservice.Template.DependencyInjection.Communication
{
    internal static class HttpServicesExtensions
    {
        internal static IServiceCollection AddHttpServices(this IServiceCollection services)
        {
            services.AddFastEndpoints(config =>
            {
                config.Assemblies = [typeof(IProjectReference).Assembly];
            });
            services.AddEndpointsApiExplorer();
            services.SwaggerDocument(o => o.AutoTagPathSegmentIndex = 2);

            return services;
        }

        internal static void UseHttpCommunication(this WebApplication app)
        {
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseFastEndpoints();
            app.UseSwaggerGen();
        }
    }
}
