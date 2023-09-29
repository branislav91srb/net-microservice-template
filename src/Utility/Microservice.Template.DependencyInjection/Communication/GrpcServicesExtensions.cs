using Microservice.Template.Communication.Grpc.Services.Flights;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Microservice.Template.DependencyInjection.Communication
{
    internal static class GrpcServicesExtensions
    {
        internal static void AddGrpcServices(this IServiceCollection services)
        {
            services.AddGrpc();
        }

        internal static void UseGrpcCommunication(this WebApplication app)
        {
            app.MapGrpcService<CreateFlightService>();
        }
    }
}
