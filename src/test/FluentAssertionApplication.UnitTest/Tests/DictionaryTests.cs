using FluentAssertionApplication.Service;
using FluentAssertions;

namespace FluentAssertionApplication.UnitTest.Tests
{
    public class DictionaryTests
    {
        #region [ Dictionarys ]

        [Fact]
        public void When_DictionariesAssertion_Then_ReturnedDictionarys()
        {
            var productService = new ProductService();

            var response = productService.DictionariesAssertion();

            response.Should().NotBeNull();
            response.Should().NotBeEmpty();
            response.Should().ContainKey(1);
            response.Should().ContainKeys(1, 2);
            response.Should().NotContainKey(5);
            response.Should().NotContainKeys(9, 10);
            response.Should().ContainValue("One");
            response.Should().ContainValues("One", "Two");
            response.Should().NotContainValue("Nine");
            response.Should().NotContainValues("Nine", "Ten");
        }

        #endregion [ Dictionarys ]

    }
}
