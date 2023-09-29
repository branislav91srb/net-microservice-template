namespace Microservice.Template.Core.Domain
{
    public class Flight
    {
        public string FlightNumber { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public DateTimeOffset Time { get; set; }
    }
}
