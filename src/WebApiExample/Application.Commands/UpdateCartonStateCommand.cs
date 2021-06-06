using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace WebApiExample.Application
{
    public record UpdateCartonStateCommand : IRequest<UpdateCartonStateStatus>
    {
    }

    public enum UpdateCartonStateStatus
    {
        Ok,
    }

    public partial class Handler : IRequestHandler<UpdateCartonStateCommand, UpdateCartonStateStatus>
    {
        public Task<UpdateCartonStateStatus> Handle(UpdateCartonStateCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
