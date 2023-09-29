using Microservice.Template.Core.Entities;

namespace Microservice.Template.Application.Repositories
{
    public interface IFlightRepository
    {
        Task<int> SaveFlightAsync(FlightEntity flightEntity, CancellationToken cancellationToken = default);

        Task<List<FlightEntity>> GetFlightsAsync(CancellationToken cancellationToken = default);
    }
}
