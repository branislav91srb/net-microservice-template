using Microservice.Template.Application.Repositories;
using Microservice.Template.Core.Domain;
using Microservice.Template.Persistence.Entities;


namespace Microservice.Template.Persistence.Repositories
{
    internal class ToDoRepository : IRepository
    {
        public Task<ToDo> GetSomethingAsync(CancellationToken cancellationToken = default)
        {
            var entity = new ToDoEntity
            {
                Id = Guid.NewGuid(),
                Title = Guid.NewGuid().ToString()
            };

            return Task.FromResult(new ToDo { Title = entity.Title });
        }
    }
}
