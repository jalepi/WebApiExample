using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiExample.Domain;

namespace WebApiExample.Application.DataObjecs
{
    public record GetOneCarton : IBelongsToCarton
    {
        public string OrganizationId { get; init; }
        public string TenantId { get; init; }
        public string CartonId { get; init; }
    }
}
