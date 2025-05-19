using System.ComponentModel.DataAnnotations;

namespace Microservice.Template.Persistence.Entities
{
    internal class ToDoEntity
    {
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }
    }
}
