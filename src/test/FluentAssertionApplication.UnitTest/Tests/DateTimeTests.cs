using FluentAssertionApplication.Service;
using FluentAssertions;

namespace FluentAssertionApplication.UnitTest.Tests
{
    public class DateTimeTests
    {

        #region [ DateTime ]

        [Fact]
        public void When_TimeOnlyAssertion_Then_ReturnedTimeOnly()
        {
            var productService = new ProductService();

            var response = productService.TimeOnlyService();

            response.Should().Be(new TimeOnly());
        }

        [Fact]
        public void When_DateOnlyAssertion_Then_ReturnedDateOnly()
        {
            var productService = new ProductService();

            var response = productService.DateOnlyService();

            response.Should().Be(new DateOnly());
        }

        [Fact]
        public void When_DateTimeAssertion_Then_ReturnedDateOnly()
        {
            var productService = new ProductService();

            var response = productService.DateTimeService();

            response.Should().BeBefore(DateTime.Now);
            response.Should().BeOnOrBefore(DateTime.Now);
        }

        #endregion [ DateTime ]
    }
}
