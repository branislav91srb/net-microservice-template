using MediatR;
using OneOf;

namespace Microservice.Template.Application.Commands
{
    public class CreateFlightCommand : IRequest<OneOf<int, Exception>>
    {
        public string FlightNumber { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public DateTimeOffset DepartureTime { get; set; }
    }
}
