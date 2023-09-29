using MediatR;
using Microservice.Template.Core.Domain;
using OneOf;

namespace Microservice.Template.Application.Queries
{
    public class GetAllFlightsQuery : IRequest<OneOf<List<Flight>, Exception>>
    {
    }
}
