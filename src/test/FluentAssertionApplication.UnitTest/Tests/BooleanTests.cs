using FluentAssertionApplication.Service;
using FluentAssertions;

namespace FluentAssertionApplication.UnitTest.Tests
{
    public class BooleanTests
    {
        #region [ Booleans ]

        [Fact]
        public void When_BooleansAssertion_Then_ReturnedTrue()
        {
            var productService = new ProductService();

            var response = productService.BooleansAssertion();

            response.Should().BeTrue();
            response.Should().Be(true);
            //response.Should().NotBeFalse();
        }

        #endregion [ Booleans ]

    }
}
