using Microservice.Template.Application.Services;
using Microservice.Template.ThirdParty.Amadeus.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Microservice.Template.DependencyInjection.ThirdParty
{
    public static class AmadeusServicesExtensions
    {
        public static void AddAmadeusServices(this IServiceCollection services)
        {
            services.AddScoped<IFlightBookingService, FlightBookingService>();
        }
    }
}
