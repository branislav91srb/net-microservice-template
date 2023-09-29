using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Microservice.Template.Persistence.DbEntities
{
    [Index("FlightNumber", IsUnique = true)]
    internal class FlightDbEntity
    {
        [Key]
        public int? Id { get; set; }

        [Required]
        public string FlightNumber { get; set; }

        [Required]
        public string From { get; set; }

        [Required]
        public string To { get; set; }

        [Required]
        public DateTimeOffset Time { get; set; }
    }
}
