using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiExample.Domain
{
    public interface IBelongsToProduct
    {
        string ProductId { get; init; }
    }
}
