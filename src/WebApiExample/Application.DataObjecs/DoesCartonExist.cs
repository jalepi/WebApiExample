using WebApiExample.Domain;

namespace WebApiExample.Application.DataObjecs
{
    public class DoesCartonExist : IBelongsToCarton
    {
        public string OrganizationId { get; init; }
        public string TenantId { get; init; }
        public string CartonId { get; init; }
    }
}
