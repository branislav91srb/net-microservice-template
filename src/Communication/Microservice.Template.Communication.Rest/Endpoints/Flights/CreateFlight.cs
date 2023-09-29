using FastEndpoints;
using MediatR;
using Microservice.Template.Application.Commands;
using Microservice.Template.Communication.Rest.Requests;
using Microsoft.AspNetCore.Http;

namespace Microservice.Template.Communication.Rest.Endpoints.Flights
{
    internal class CreateFlight : Endpoint<CreateFlightRequest, int>
    {
        private readonly IMediator _mediatr;

        public CreateFlight(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        public override void Configure()
        {
            Post("/api/tickets");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CreateFlightRequest req, CancellationToken ct)
        {
            var data = await _mediatr.Send(new CreateFlightCommand
            {
                FlightNumber = req.FlightNumber,
                From = req.From,
                To = req.To,
                DepartureTime = req.Time
            });

            var result = data.Match(success => Results.Ok(success), error => Results.Problem(error.Message));

            await SendResultAsync(result);
        }
    }
}
