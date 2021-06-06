using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace WebApiExample.Application.CartonHandler
{
    public class GetCartonsTests : BaseTests
    {
        [Fact]
        public async Task Given_one_valid_query_Expect_tb_ok_and_many_items()
        {
            // arrange
            var input = Mock.Of<GetCartonsQuery>();
            var output = Domain.ResultOf.Create(GetCartonsStatus.Ok, Mock.Of<Cartons>());

            Fake.Setup(o => o.Handle(
                    It.IsAny<GetCartonsQuery>(),
                    It.IsAny<CancellationToken>()))
                .ReturnsAsync(output);


            // act
            var result = await Subject.Handle(input, default);

            // assert
            Assert.Equal(GetCartonsStatus.Ok, result.Status);
            Assert.NotNull(result.Content);
        }
    }
}
