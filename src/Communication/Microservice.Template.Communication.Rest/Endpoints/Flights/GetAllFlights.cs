using FastEndpoints;
using MediatR;
using Microservice.Template.Application.Queries;
using Microservice.Template.Communication.Rest.Responses.Flights;
using Microsoft.AspNetCore.Http;

namespace Microservice.Template.Communication.Rest.Endpoints.Flights;

internal class GetAllFlights : EndpointWithoutRequest<GetAllFlightsResponse>
{
    private readonly IMediator _mediatr;

    public GetAllFlights(IMediator mediatr)
    {
        _mediatr = mediatr;
    }

    public override void Configure()
    {
        Get("/api/flights");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        var data = await _mediatr.Send(new GetAllFlightsQuery(), ct);

        var result = data.Match(success =>
        {
            var response = new GetAllFlightsResponse { Flights = success };
            return Results.Ok(response);
        }, error =>
        {
            return Results.Problem(error.Message);
        });

        await SendResultAsync(result);
    }
}

