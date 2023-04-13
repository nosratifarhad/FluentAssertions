using FluentAssertionApplication.Service;
using FluentAssertions;
using System.Net;

namespace FluentAssertionApplication.UnitTest.Tests
{
    public class HttpResponseMessageTests
    {
        #region [ HttpResponseMessages ]

        [Fact]
        public void When_HttpResponseMessagesAssertion_Then_ReturnedHttpResponseMessage()
        {
            var productService = new ProductService();

            var response = productService.HttpResponseMessagesAssertion();

            response.Should().BeSuccessful("it's set to OK");
            response.Should().HaveStatusCode(HttpStatusCode.OK);
        }

        #endregion [ HttpResponseMessages ]

    }
}
