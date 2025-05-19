using Grpc.Core;
using Microservice.Template.Communication.Grpc.Protos.ToDo;

namespace Microservice.Template.Communication.Grpc.Services.ToDo
{
    internal class GetToDoService : ToDoService.ToDoServiceBase
    {
        public override Task<GetToDoResponse> GetToDo(GetToDoRequest request, ServerCallContext context)
        {
            return Task.FromResult(new GetToDoResponse());
        }
    }
}
