using MediatR;
using Microservice.Template.Application.Queries;
using Microservice.Template.Application.Repositories;
using Microservice.Template.Core.Domain;
using OneOf;

namespace Microservice.Template.Infrastructure.Handlers
{
    internal class GetAllFlightsHandler : IRequestHandler<GetAllFlightsQuery, OneOf<List<Flight>, Exception>>
    {
        private readonly IFlightRepository _flightRepository;

        public GetAllFlightsHandler(IFlightRepository flightRepository)
        {
            _flightRepository = flightRepository;
        }

        public async Task<OneOf<List<Flight>, Exception>> Handle(GetAllFlightsQuery request, CancellationToken cancellationToken)
        {
            var flights = await _flightRepository.GetFlightsAsync();

            return flights.Select(x => new Flight { FlightNumber = x.FlightNumber, From = x.From, To = x.To, Time = x.Time }).ToList();
        }
    }
}
