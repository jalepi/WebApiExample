using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiExample.Domain;

namespace WebApiExample.Application.DataObjecs
{
    public record GetManyCartons : IBelongsToOrganization, IBelongsToTenant, IPage
    {
        public string OrganizationId { get; init; }
        public string TenantId { get; init; }
        public int StartIndex { get; init; }
        public int Count { get; init; }
    }
}
