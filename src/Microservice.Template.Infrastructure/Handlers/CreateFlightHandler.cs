using MediatR;
using Microservice.Template.Application.Commands;
using Microservice.Template.Application.Repositories;
using Microservice.Template.Core.Entities;
using OneOf;

namespace Microservice.Template.Infrastructure.Handlers
{
    internal class CreateFlightHandler : IRequestHandler<CreateFlightCommand, OneOf<int, Exception>>
    {
        private readonly IFlightRepository _flightRepository;

        public CreateFlightHandler(IFlightRepository flightRepository)
        {
            _flightRepository = flightRepository;
        }

        public async Task<OneOf<int, Exception>> Handle(CreateFlightCommand request, CancellationToken cancellationToken)
        {
            var flightEntity = new FlightEntity
            {
                FlightNumber = request.FlightNumber,
                From = request.From,
                To = request.To,
                Time = request.DepartureTime
            };

            var id = await _flightRepository.SaveFlightAsync(flightEntity, cancellationToken);

            return id;
        }
    }
}
