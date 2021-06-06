using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebApiExample.Domain;

namespace WebApiExample.Application
{
    public record GetCartonsQuery : IRequest<IResultOf<GetCartonsStatus, Cartons>>
    {
    }

    public enum GetCartonsStatus
    {
        Ok,
    }

    public record Cartons
    {
    }

    public partial class Handler : IRequestHandler<GetCartonsQuery, IResultOf<GetCartonsStatus, Cartons>>
    {
        public Task<IResultOf<GetCartonsStatus, Cartons>> Handle(GetCartonsQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
