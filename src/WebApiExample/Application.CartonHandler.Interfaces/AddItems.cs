using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiExample.Domain;

namespace WebApiExample.Application
{
    public partial interface ICartonHandler
    {
        Task<ItemReceivementStatus> AddItems(ItemsSent items);
    }

    public record ItemsSent
        : IBelongsToOrganization
        , IBelongsToTenant
    {
        public string OrganizationId { get; init; }
        public string TenantId { get; init; }
        public string CartonId { get; init; }
        public IReadOnlyCollection<string> Items { get; init; }
    }

    public enum ItemReceivementStatus
    {
        Ok,
        CartonNotFound,
        Unknown,
    }
}
