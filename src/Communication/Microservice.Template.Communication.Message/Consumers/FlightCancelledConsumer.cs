using MassTransit;
using Microservice.Template.Communication.Message.Messages;
using Microsoft.Extensions.Logging;

namespace Microservice.Template.Communication.Message.Consumers
{
    internal class FlightCancelledConsumer : IConsumer<FlightCancelled>
    {
        private readonly ILogger<FlightCancelledConsumer> _logger;

        public FlightCancelledConsumer(ILogger<FlightCancelledConsumer> logger)
        {
            _logger = logger;
        }

        public async Task Consume(ConsumeContext<FlightCancelled> context)
        {
            _logger.LogWarning("Flight with number {flightNumber} has been canceled", 
                context.Message.FlightNumber);
        }
    }
}
