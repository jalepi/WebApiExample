using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiExample.Application
{
    public partial interface ICartonHandler
    {
        Task<ItemReceivementStatus> AddItems(IItemsSent items);
    }

    public interface IItemsSent
    {
    }

    public enum ItemReceivementStatus
    {
        Ok,
    }
}
