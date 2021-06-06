using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiExample.Domain;

namespace WebApiExample.Application.DataObjecs
{
    public record AddItems : IBelongsToTenant
    {
        public string OrganizationId { get; init; }
        public string TenantId { get; init; }
        
        public IReadOnlyCollection<Item> Items { get; init; }

        public record Item : IBelongsToProduct
        {
            public string ProductId { get; init; }
            public string ItemId { get; init; }
        }
    }
}
