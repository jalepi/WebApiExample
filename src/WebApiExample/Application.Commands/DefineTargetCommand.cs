using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace WebApiExample.Application
{

    public record DefineTargetCommand : IRequest<DefineTargetStatus>
    {
    }

    public enum DefineTargetStatus
    {
        Ok,
    }
    public partial class Handler : IRequestHandler<DefineTargetCommand, DefineTargetStatus>
    {
        public Task<DefineTargetStatus> Handle(DefineTargetCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
