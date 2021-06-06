using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace WebApiExample.Application.CartonHandler
{
    public class AddItemsTests : BaseTests
    {
        public AddItemsTests() : base()
        {
            Fake = moq.Create<ICartonHandler>();
            Fake.Setup(o => o.AddItems(
                    It.IsAny<ItemsSent>()))
                .ReturnsAsync(ItemReceivementStatus.Ok);

            Subject = Fake.Object;
        }

        [Fact]
        public async Task Given_one_valid_command_Expect_tb_ok()
        {
            // arrange

            var items = new ItemsSent { };

            // act
            var result = await Subject.AddItems(items);

            // assert
            Assert.Equal(ItemReceivementStatus.Ok, result);
        }
    }
}
