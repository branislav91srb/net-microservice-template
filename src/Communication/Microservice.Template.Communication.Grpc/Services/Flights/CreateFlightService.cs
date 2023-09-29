using Grpc.Core;
using Microservice.Template.Communication.Grpc.Protos.Flights;

namespace Microservice.Template.Communication.Grpc.Services.Flights
{
    internal class CreateFlightService : FlightsService.FlightsServiceBase
    {
        public override Task<CreateResponse> CreateFlight(CreateRequest request, ServerCallContext context)
        {
            return Task.FromResult(new CreateResponse());
        }
    }
}
