using Microsoft.Extensions.Logging;

namespace WebApiExample.Application
{
    public partial class Handler
    {
        protected ILogger Logger { get; }
        protected IReader Reader { get; }
        protected IWriter Writer { get; }

        public Handler(ILogger<Handler> logger, IReader reader, IWriter writer)
        {
            Logger = logger;
            Reader = reader;
            Writer = writer;
        }
    }
}
