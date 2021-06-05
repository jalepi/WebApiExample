using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiExample.Application
{
    public partial interface ICartonHandler
    {
        Task<CartonStatusState> UpdateCartonState(ICartonStateUpdated cartonState);
    }

    public interface ICartonStateUpdated
    {
    }

    public enum CartonStatusState
    {
        Ok,
    }
}
