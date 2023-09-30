using Microservice.Template.Application.Repositories;
using Microservice.Template.Core.Entities;
using Microservice.Template.Persistence.DbContexts;
using Microservice.Template.Persistence.DbEntities;
using Microsoft.EntityFrameworkCore;

namespace Microservice.Template.Persistence.Repositories
{
    internal class FlightRepository : IFlightRepository
    {
        private readonly AppDbContext _dbContext;

        public FlightRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<FlightEntity>> GetFlightsAsync(CancellationToken cancellationToken = default)
        {
            var flights = await _dbContext.Flights.AsNoTracking().ToListAsync();

            return flights.Select(f => new FlightEntity { FlightNumber = f.FlightNumber, From = f.From, To = f.To, Id = f.Id, Time = f.Time }).ToList();
        }

        public async Task<int> SaveFlightAsync(FlightEntity flightEntity, CancellationToken cancellationToken = default)
        {
            var entity = new FlightDbEntity
            {
                FlightNumber = flightEntity.FlightNumber,
                From = flightEntity.From,
                To = flightEntity.To,
                Time = flightEntity.Time
            };

            _dbContext.Flights.Add(entity);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return entity.Id!.Value;
        }
    }
}
