using Microservice.Template.Core.Domain;

namespace Microservice.Template.Application.Repositories
{
    public interface IRepository
    {
        Task<ToDo> GetSomethingAsync(CancellationToken cancellationToken = default);
    }
}
