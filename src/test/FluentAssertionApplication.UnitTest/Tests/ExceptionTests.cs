using FluentAssertionApplication.Service;
using FluentAssertions;

namespace FluentAssertionApplication.UnitTest.Tests
{
    public class ExceptionTests
    {

        #region [ Exceptions ]

        [Fact]
        public void When_ExceptionsAssertion_Then_ThrowExceptions()
        {
            var productService = new ProductService();

            FluentActions.Invoking(() => productService.ExceptionsAssertion()).Should().Throw<ArgumentException>()
                .WithMessage("Assertion For Exception.");
        }

        #endregion [ Exceptions ]

    }
}
