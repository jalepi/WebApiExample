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
        protected Handler Subject { get; init; }
        protected Mock<Handler> Fake { get; init; }

        public BaseTests()
        {
            Fake = moq.Create<Handler>();
            Subject = Fake.Object;
        }
    }
}
