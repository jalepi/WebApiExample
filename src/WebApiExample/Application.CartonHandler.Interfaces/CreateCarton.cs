using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiExample.Application
{
    public partial interface ICartonHandler
    {
        Task<CartonCreatedStatus> CreateCarton(CartonCreated carton);
    }

    public record CartonCreated
    {
    }

    public enum CartonCreatedStatus
    {
        Ok,
    }
}
