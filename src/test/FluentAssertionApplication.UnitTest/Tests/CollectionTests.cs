using FluentAssertionApplication.Domain.Entity;
using FluentAssertionApplication.Service;
using FluentAssertions;

namespace FluentAssertionApplication.UnitTest.Tests
{
    public class CollectionTests
    {

        #region [ Collection ]

        [Fact]
        public void When_CollectionIntAssertion_Then_ReturnedIEnumerableInt()
        {
            var productService = new ProductService();

            var response = productService.CollectionIntService();

            response.Should().NotBeEmpty()
                .And.HaveCount(4)
                .And.ContainInOrder(new[] { 2, 5 })
                .And.ContainItemsAssignableTo<int>();

            response.Should().Equal(new List<int> { 1, 2, 5, 8 });
            response.Should().Equal(1, 2, 5, 8);
            response.Should().BeEquivalentTo(new[] { 8, 2, 1, 5 });
            response.Should().NotBeEquivalentTo(new[] { 8, 2, 3, 5 });

            response.Should().HaveCount(c => c > 3)
                .And.OnlyHaveUniqueItems();

            response.Should().HaveCountGreaterThan(3);
            response.Should().HaveCountGreaterThanOrEqualTo(4);
            response.Should().HaveCountLessThanOrEqualTo(4);
            response.Should().HaveCountLessThan(5);
            response.Should().NotHaveCount(3);
            response.Should().HaveSameCount(new[] { 6, 2, 0, 5 });
            response.Should().NotHaveSameCount(new[] { 6, 2, 0 });

            response.Should().StartWith(1);
            response.Should().StartWith(new[] { 1, 2 });
            response.Should().EndWith(8);
            response.Should().EndWith(new[] { 5, 8 });


        }

        [Fact]
        public void When_ListStringAssertion_Then_ReturnedListString()
        {
            var productService = new ProductService();

            var response = productService.ListStringService();

            response.Should().NotBeEmpty();
            response.Should().Equal(new string[] { "one", "two", "three" });
            response.Should().BeEquivalentTo(new[] { "one", "two", "three" });
            response.Should().NotBeEquivalentTo(new[] { "one3", "two2", "three1" });
        }

        [Fact]
        public void When_ListProductIntAssertion_Then_ReturnedListProduct()
        {
            IEnumerable<Product> someProperty = new List<Product>()
            {
                new()
                {
                    ProductId = 1,
                    ProductName = "ProductName 1"
                },
                new()
                {
                    ProductId = 2,
                    ProductName = "ProductName 2"
                },

            };

            var productService = new ProductService();

            var response = productService.ListProductIntService();

            response.Should().SatisfyRespectively(
            first =>
            {
                first.ProductId.Should().Be(1);
                first.ProductName.Should().StartWith("ProductName 1");
            },
            second =>
            {
                second.ProductId.Should().Be(2);
                second.ProductName.Should().StartWith("ProductName 2");
            });
            response.Should().AllSatisfy(x =>
            {
                x.ProductId.Should().BePositive();
                x.ProductName.Should().StartWith("ProductName");
            });
            response.Should().BeInAscendingOrder(x => x.ProductName);
            response.Select(c => c.ProductName).Should().Equal(someProperty.Select(c => c.ProductName));
            response.Select(c => c.ProductName).Should().StartWith(someProperty.Select(c => c.ProductName));
            response.Select(c => c.ProductName).Should().EndWith(someProperty.Select(c => c.ProductName));

        }

        #endregion [ Collection ]

    }
}
