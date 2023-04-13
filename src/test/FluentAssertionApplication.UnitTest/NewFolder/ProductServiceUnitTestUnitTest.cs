using FluentAssertionApplication.Service;
using FluentAssertions;

namespace FluentAssertionApplication.UnitTest.NewFolder
{
    public class ProductServiceUnitTestUnitTest
    {
        [Fact]
        public void When_NumericTypeIntAssertion_Then_ReturnedFive()
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
    }
}