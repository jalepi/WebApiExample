using System;

namespace WebApiExample.Domain
{
    public interface IResultOf<out TStatus, out TContent> where TStatus : Enum
    {
        public TStatus Status { get; }
        public TContent Content { get; }
        public bool IsOk { get; }
    }
}
