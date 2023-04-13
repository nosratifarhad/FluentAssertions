using FluentAssertionApplication.Service;
using FluentAssertions;

namespace FluentAssertionApplication.UnitTest.Tests
{
    public class NumericTypeTests
    {
        #region [ Numeric Type ]

        [Fact]
        public void When_NumericTypeIntAssertion_Then_ReturnedValidNumber()
        {
            var productService = new ProductService();

            var response = productService.NumericTypeIntAssertion();

            response.Should().BeGreaterThanOrEqualTo(5);
            response.Should().BeGreaterThanOrEqualTo(3);
            response.Should().BeGreaterThan(4);
            response.Should().BeLessThanOrEqualTo(5);
            response.Should().BeLessThan(6);
            response.Should().BePositive();
            response.Should().Be(5);
            response.Should().NotBe(10);
            response.Should().BeInRange(1, 10);
            response.Should().NotBeInRange(6, 10);
            response.Should().Match(x => x % 2 == 1);
        }

        [Fact]
        public void When_NumericTypeIntNulableAssertion_Then_ReturnedValidNumber()
        {
            var productService = new ProductService();

            var response = productService.NumericTypeIntNulableAssertion();

            response.Should().Be(3);
        }

        [Fact]
        public void When_NumericTypeFloatAssertion_Then_ReturnedValidNumber()
        {
            var productService = new ProductService();

            var response = productService.NumericTypeFloatAssertion();

            response.Should().NotBeApproximately(2.5F, 0.5F);
        }

        [Fact]
        public void When_NumericTypeNegativeAssertion_Then_ReturnedValidNumber()
        {
            var productService = new ProductService();

            var response = productService.NumericTypeNegativeAssertion();

            response.Should().BeNegative();
        }

        #endregion [ Numeric Type ]
    }
}
