using FastEndpoints;
using Microservice.Template.Application.Services;

namespace Microservice.Template.Communication.Rest.Endpoints.GetTodos;

internal class GetTodosEndpoint : EndpointWithoutRequest<object>
{
    private readonly IService _service;

    public GetTodosEndpoint(IService service)
    {
        _service = service;
    }

    public override void Configure()
    {
        Get("/v1/todos");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        var result = await _service.DoSomethingAsync();

        await SendOkAsync(result);
    }
}

