using Moq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace WebApiExample.Application.CartonHandler
{
    public class AddItemsTests : BaseTests
    {
        public AddItemsTests() : base()
        {
            Fake = moq.Create<Handler>();
            Fake.Setup(o => o.Handle(
                    It.IsAny<AddItemsCommand>(),
                    It.IsAny<CancellationToken>()))
                .ReturnsAsync(AddItemsStatus.Ok);

            Subject = Fake.Object;
        }

        [Fact]
        public async Task Given_one_valid_command_Expect_tb_ok()
        {
            // arrange

            var items = new AddItemsCommand { };

            // act
            var result = await Subject.Handle(items, default);

            // assert
            Assert.Equal(AddItemsStatus.Ok, result);
        }
    }
}
