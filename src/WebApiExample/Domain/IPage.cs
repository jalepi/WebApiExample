namespace WebApiExample.Domain
{
    public interface IPage
    {
        int StartIndex { get; }
        int Count { get; }
    }
}
