using System.Threading.Tasks;
using WebApiExample.Application.DataObjecs;

namespace WebApiExample.Application
{
    public interface IWriter
    {

        Task AddItems(AddItems items);
    }
}