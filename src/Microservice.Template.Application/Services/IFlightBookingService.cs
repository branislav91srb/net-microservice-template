namespace Microservice.Template.Application.Services
{
    public interface IFlightBookingService
    {
        Task<string?> BookFlightAsync(int userId, string flightNumber, int numberOfSeats);
    }
}
