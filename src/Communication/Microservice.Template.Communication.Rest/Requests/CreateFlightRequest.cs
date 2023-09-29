namespace Microservice.Template.Communication.Rest.Requests
{
    public class CreateFlightRequest
    {
        public string FlightNumber { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public DateTimeOffset Time { get; set; }
    }
}
