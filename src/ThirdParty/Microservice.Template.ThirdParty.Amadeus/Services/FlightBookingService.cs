using Microservice.Template.Application.Services;

namespace Microservice.Template.ThirdParty.Amadeus.Services
{
    internal class FlightBookingService : IFlightBookingService
    {
        public async Task<string?> BookFlightAsync(int userId, string flightNumber, int numberOfSeats)
        {
            await Task.Delay(300);

            return Guid.NewGuid().ToString().Split('-').First();
        }
    }
}
