using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var output = (CartonsStatus.Ok, Mock.Of<Cartons>());

            Fake.Setup(o => o.GetCartons(
                    It.IsAny<GetCartonsQuery>()))
                .ReturnsAsync(output);


            // act
            var result = await Subject.GetCartons(input);

            // assert
            Assert.Equal(CartonsStatus.Ok, result.result);
            Assert.NotNull(result.cartons);
        }
    }
}
