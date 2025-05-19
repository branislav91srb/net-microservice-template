using Microservice.Template.Application.Repositories;
using Microservice.Template.Application.Services;
using Microservice.Template.Core.Domain;

namespace Microservice.Template.Infrastructure.Services;

internal class Service : IService
{
    private readonly IRepository _repository;

    public Service(IRepository repository)
    {
        _repository = repository;
    }

    public Task<ToDo> DoSomethingAsync()
    {
        return _repository.GetSomethingAsync();
    }
}