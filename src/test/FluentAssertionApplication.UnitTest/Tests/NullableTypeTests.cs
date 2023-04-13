using FluentAssertionApplication.Service;
using FluentAssertions;

namespace FluentAssertionApplication.UnitTest.Tests
{
    public class NullableTypeTests
    {

        #region [ Nullable Types ]

        [Fact]
        public void When_NullableTypeIntAssertion_Then_ReturnedValidNumber()
        {
            var productService = new ProductService();

            var response = productService.NullableTypeIntAssertion();

            response.Should().HaveValue();
            response.Should().NotBeNull();
        }

        [Fact]
        public void When_NullableTypesAssertion_Then_ReturnedNull()
        {
            var productService = new ProductService();

            var response = productService.NullableTypesAssertion();

            response.Should().NotHaveValue();
            response.Should().BeNull();
        }

        [Fact]
        public void When_NullableTypeShortAssertion_Then_ReturnedNull()
        {
            var productService = new ProductService();

            var response = productService.NullableTypeShortAssertion();

            response.Should().NotHaveValue();
            response.Should().BeNull();
            response.Should().Match(x => !x.HasValue || x > 0);
        }

        #endregion [ Nullable Types ]

    }
}
