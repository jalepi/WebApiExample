using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiExample.Application
{
    public partial class CartonHandler : ICartonHandler
    {
        private readonly ILogger logger;
        private readonly IReader reader;
        private readonly IWriter writer;

        public CartonHandler(ILogger<CartonHandler> logger, IReader reader, IWriter writer)
        {
            this.logger = logger;
            this.reader = reader;
            this.writer = writer;
        }
    }
}
