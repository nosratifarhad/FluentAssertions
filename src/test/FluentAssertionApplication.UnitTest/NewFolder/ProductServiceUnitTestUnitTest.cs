using FluentAssertionApplication.Domain.Entity;
using FluentAssertionApplication.Domain.Enum;
using FluentAssertionApplication.Service;
using FluentAssertions;
using System.Net;

namespace FluentAssertionApplication.UnitTest.NewFolder
{
    public class ProductServiceUnitTestUnitTest
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

        #region [ Booleans ]

        [Fact]
        public void When_BooleansAssertion_Then_ReturnedTrue()
        {
            var productService = new ProductService();

            var response = productService.BooleansAssertion();

            response.Should().BeTrue();
            response.Should().Be(true);
            //response.Should().NotBeFalse();
        }

        #endregion [ Booleans ]

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

        #region [ DateTime ]

        [Fact]
        public void When_TimeOnlyAssertion_Then_ReturnedTimeOnly()
        {
            var productService = new ProductService();

            var response = productService.TimeOnlyAssertion();

            response.Should().Be(new TimeOnly());
        }

        [Fact]
        public void When_DateOnlyAssertion_Then_ReturnedDateOnly()
        {
            var productService = new ProductService();

            var response = productService.DateOnlyAssertion();

            response.Should().Be(new DateOnly());
        }

        [Fact]
        public void When_DateTimeAssertion_Then_ReturnedDateOnly()
        {
            var productService = new ProductService();

            var response = productService.DateTimeAssertion();

            response.Should().BeBefore(DateTime.Now);
            response.Should().BeOnOrBefore(DateTime.Now);
        }

        #endregion [ DateTime ]

        #region [ Collection ]

        [Fact]
        public void When_CollectionIntAssertion_Then_ReturnedIEnumerableInt()
        {
            var productService = new ProductService();

            var response = productService.CollectionIntAssertion();

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

            var response = productService.ListStringAssertion();

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

            var response = productService.ListProductIntAssertion();

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

        #region [ Guid ]

        [Fact]
        public void When_GuidsAssertion_Then_ReturnedGuid()
        {
            Guid otherGuid = Guid.NewGuid();

            var productService = new ProductService();

            var response = productService.GuidsAssertion();

            response.Should().NotBe(otherGuid);
            response.Should().NotBeEmpty();
            //response.Should().Be("11111111-aaaa-bbbb-cccc-999999999999");
        }

        #endregion [ Guid ]

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