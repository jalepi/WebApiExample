using MediatR;
using System.Threading;
using System.Threading.Tasks;
using WebApiExample.Domain;

namespace WebApiExample.Application
{
    public record GetCartonQuery : IRequest<IResultOf<GetCartonStatus, CartonDetails>>
    {
    }

    public enum GetCartonStatus
    {

    }

    public record CartonDetails
    {
    }

    public partial class Handler : IRequestHandler<GetCartonQuery, IResultOf<GetCartonStatus, CartonDetails>>
    {
        public Task<IResultOf<GetCartonStatus, CartonDetails>> Handle(GetCartonQuery request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
