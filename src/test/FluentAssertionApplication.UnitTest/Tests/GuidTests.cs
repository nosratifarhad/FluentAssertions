using FluentAssertionApplication.Service;
using FluentAssertions;

namespace FluentAssertionApplication.UnitTest.Tests
{
    public class GuidTests
    {
        #region [ Guid ]

        [Fact]
        public void When_GuidsAssertion_Then_ReturnedGuid()
        {
            Guid otherGuid = Guid.NewGuid();

            var productService = new ProductService();

            var response = productService.GuidsAssertion();

            response.Should().NotBe(otherGuid);
            response.Should().NotBeEmpty();
            //response.Should().Be("11111111-aaaa-bbbb-cccc-999999999999");
        }

        #endregion [ Guid ]

    }
}
