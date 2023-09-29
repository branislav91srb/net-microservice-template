namespace Microservice.Template.Core.Entities
{
    public class FlightEntity
    {
        public int? Id { get; set; }

        public string FlightNumber { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public DateTimeOffset Time { get; set; }
    }
}
