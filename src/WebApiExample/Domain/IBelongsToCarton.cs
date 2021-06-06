namespace WebApiExample.Domain
{
    public interface IBelongsToCarton : IBelongsToOrganization, IBelongsToTenant
    {
        string CartonId { get; init; }
    }
}
