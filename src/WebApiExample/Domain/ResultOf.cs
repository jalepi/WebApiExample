using System;

namespace WebApiExample.Domain
{
    public static class ResultOf
    {
        public static IResultOf<S, C> Create<S, C>(S status, C content) where S : Enum
        {
            return new InternalResultOf<S, C>
            {
                Content = content,
                Status = status,
                IsOk = default(S).Equals(status),
            };
        }

        private record InternalResultOf<S, C> : IResultOf<S, C> where S : Enum
        {
            public S Status { get; init; }

            public C Content { get; init; }

            public bool IsOk { get; init; }
        }
    }
}
