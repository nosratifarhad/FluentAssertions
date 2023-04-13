using FluentAssertionApplication.Domain.Enum;
using FluentAssertionApplication.Service;
using FluentAssertions;

namespace FluentAssertionApplication.UnitTest.Tests
{
    public class EnumTests
    {

        #region [ Enum ]

        [Fact]
        public void When_EnumsAssertion_Then_ReturnedEnum()
        {
            var productService = new ProductService();

            var response = productService.EnumsAssertion();

            response.Should().Be(EnumForTest.None);
            response.Should().NotBe(EnumForTest.NoneNone);
            response.Should().BeOneOf(EnumForTest.None, EnumForTest.NoneNone);

            response.Should().HaveFlag(EnumForTest.None);
            response.Should().NotHaveFlag(EnumForTest.NoneNone);
        }

        #endregion [ Enum ]

    }
}
