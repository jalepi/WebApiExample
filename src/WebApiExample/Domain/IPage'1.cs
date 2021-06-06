using System.Collections.Generic;

namespace WebApiExample.Domain
{
    public interface IPage<T> : IPage
    {
        IReadOnlyCollection<T> Items { get; }
    }
}
