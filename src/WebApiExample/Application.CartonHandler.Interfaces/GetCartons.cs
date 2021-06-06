using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiExample.Application
{
    public partial interface ICartonHandler
    {
        Task<(CartonsStatus result, Cartons cartons)> GetCartons(GetCartonsQuery query);
    }

    public record GetCartonsQuery
    {
    }

    public enum CartonsStatus
    {
        Ok,
    }

    public record Cartons
    {
    }
}
