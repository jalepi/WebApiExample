using System.Threading;
using System.Threading.Tasks;
using WebApiExample.Application.DataObjecs;

namespace WebApiExample.Application
{
    public interface IWriter
    {
        Task Write(InsertItems command, CancellationToken cancellationToken);

        Task Write(InsertCarton command, CancellationToken cancellationToken);

        Task Write(UpdateCarton command, CancellationToken cancellationToken);
    }
}