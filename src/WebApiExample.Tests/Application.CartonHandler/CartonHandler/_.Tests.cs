using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiExample.Application
{
    public class BaseTests
    {
        protected readonly MockRepository moq = new MockRepository(MockBehavior.Strict);
        protected ICartonHandler Subject { get; init; }
        protected Mock<ICartonHandler> Fake { get; init; }

        public BaseTests()
        {
            Fake = moq.Create<ICartonHandler>();
            Subject = Fake.Object;
        }
    }
}
