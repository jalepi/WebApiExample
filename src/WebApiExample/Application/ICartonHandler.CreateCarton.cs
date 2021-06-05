using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiExample.Application
{
    public partial interface ICartonHandler
    {
        Task<CartonCreatedStatus> CreateCarton(ICartonCreated carton);
    }

    public interface ICartonCreated
    {
    }

    public enum CartonCreatedStatus
    {
        Ok,
    }
}
