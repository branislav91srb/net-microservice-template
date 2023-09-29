using Microservice.Template.Persistence.DbEntities;
using Microsoft.EntityFrameworkCore;

namespace Microservice.Template.Persistence.DbContexts
{
    internal class AppDbContext : DbContext
    {
        public DbSet<FlightDbEntity> Flights { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "AppDb");
        }
    }
}
