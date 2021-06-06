using System.Collections.Generic;
using WebApiExample.Domain;

namespace WebApiExample.Application.DataObjecs
{
    public record ManyCartons : IPage<ManyCartons.Carton>
    {
        public IReadOnlyCollection<Carton> Items { get; init; }
        public int StartIndex { get; init; }
        public int Count { get; init; }

        public record Carton : IBelongsToCarton 
        {
            public string OrganizationId { get; init; }
            public string TenantId { get; init; }
            public string CartonId { get; init; }
        }
    }
}
