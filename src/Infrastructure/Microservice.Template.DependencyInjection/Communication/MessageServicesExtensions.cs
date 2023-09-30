using Microsoft.Extensions.DependencyInjection;
using MassTransit;
using Microservice.Template.Communication.Message.Consumers;

namespace Microservice.Template.DependencyInjection.Communication
{
    public static class MessageServicesExtensions
    {
        public static void AddRabbitMq(this IServiceCollection services)
        {
            services.AddMassTransit(x =>
            {
                x.UsingRabbitMq((context, factoryConfiguration) =>
                {
                    var host = "localhost";
                    var port = "5213";
                    var username = "guest";
                    var password = "guest";

                    factoryConfiguration.Host(host, ushort.Parse(port), "/", hostConfiguration =>
                    {
                        hostConfiguration.Username(username);
                        hostConfiguration.Password(password);
                    });

                    factoryConfiguration.ConfigureEndpoints(context);
                    factoryConfiguration.ClearSerialization();
                    factoryConfiguration.UseRawJsonSerializer();
                });

                x.AddConsumer<FlightCancelledConsumer>();
            });
        }
    }
}
