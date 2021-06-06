using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiExample.Application
{
    public partial interface ICartonHandler
    {
        Task<(CartonStatus result, CartonDetails carton)> GetCarton(GetCartonQuery query);
    }

    public record GetCartonQuery
    {
    }

    public enum CartonStatus
    {

    }

    public record CartonDetails
    {
    }
}
