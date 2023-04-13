using FluentAssertionApplication.Service;
using FluentAssertions;
namespace FluentAssertionApplication.UnitTest.Tests
{
    public class StringTests
    {

        #region [ Strings ]

        [Fact]
        public void When_StringEmptyAssertion_Then_ReturnedEmpty()
        {
            var productService = new ProductService();

            var response = productService.StringEmptyAssertion();

            response.Should().NotBeNull();
            response.Should().BeEmpty();
            response.Should().HaveLength(0);
            response.Should().BeNullOrWhiteSpace();
        }

        [Fact]
        public void When_StringNullAssertion_Then_ReturnedNull()
        {
            var productService = new ProductService();

            var response = productService.StringNullAssertion();

            response.Should().BeNull();
            response.Should().BeNullOrWhiteSpace();

        }

        [Fact]
        public void When_StringMailAssertion_Then_ReturnedEmailAddress()
        {
            var productService = new ProductService();

            var response = productService.StringMailAssertion();

            response.Should().Be("nosratifarhad01@gmail.com");
            response.Should().Contain("nosratifarhad01@gmail.com");
            response.Should().Match("*@*.com");
            response.Should().MatchEquivalentOf("*@*.COM");
        }

        [Fact]
        public void When_StringDynamicAssertion_Then_ReturnedStringDynamic()
        {
            var productService = new ProductService();

            var response = productService.StringDynamicAssertion();

            response.Should().BeOneOf(
                string.Empty,
                "this is dynamic method"
            );
        }

        #endregion [ Strings ]

    }
}
