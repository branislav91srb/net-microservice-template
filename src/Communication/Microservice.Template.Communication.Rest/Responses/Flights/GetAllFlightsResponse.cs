using Microservice.Template.Core.Domain;

namespace Microservice.Template.Communication.Rest.Responses.Flights
{
    internal class GetAllFlightsResponse
    {
        public List<Flight> Flights { get; set; }
    }
}
