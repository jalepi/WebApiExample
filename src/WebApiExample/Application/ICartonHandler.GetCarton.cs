using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiExample.Application
{
    public partial interface ICartonHandler
    {
        Task<(CartonStatus result, ICartonDetails carton)> GetCarton(IGetCartonQuery query);
    }

    public interface IGetCartonQuery
    {
    }

    public enum CartonStatus
    {

    }

    public interface ICartonDetails
    {
    }
}
