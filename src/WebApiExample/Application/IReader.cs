using System.Threading;
using System.Threading.Tasks;
using WebApiExample.Application.DataObjecs;

namespace WebApiExample.Application
{
    public interface IReader
    {
        Task<bool> Read(DoesCartonExist payload, CancellationToken cancellationToken);

        Task<OneCarton> Read(GetOneCarton payload, CancellationToken cancellationToken);

        Task<ManyCartons> Read(GetManyCartons payload, CancellationToken cancellationToken);
    }
}
