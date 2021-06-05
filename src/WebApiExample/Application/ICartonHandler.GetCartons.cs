using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiExample.Application
{
    public partial interface ICartonHandler
    {
        Task<(CartonsStatus result, ICartons carton)> GetCartons(IGetCartonsQuery query);
    }

    public interface IGetCartonsQuery
    {
    }

    public enum CartonsStatus
    {
        Ok,
    }

    public interface ICartons
    {
    }
}
