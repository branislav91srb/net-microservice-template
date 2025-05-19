using Microservice.Template.Core.Domain;

namespace Microservice.Template.Application.Services
{
    public interface IService
    {
        Task<ToDo> DoSomethingAsync();
    }
}
