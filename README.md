# FluentAssertions

## Headline Implement 

* Nullable Types
    - you can get [tutorial Link](https://fluentassertions.com/nullabletypes/)
        ```scharp
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
        ```
* Booleans
    - you can get [tutorial Link](https://fluentassertions.com/booleans/)

* Strings
    - you can get [tutorial Link](https://fluentassertions.com/strings/)

* Numeric Types & IComparable
    - you can get [tutorial Link](https://fluentassertions.com/numerictypes/)

* Dates & Times
    - you can get [tutorial Link](https://fluentassertions.com/datetimespans/)

* Collections
    - you can get [tutorial Link](https://fluentassertions.com/collections/)

* Dictionaries
    - you can get [tutorial Link](https://fluentassertions.com/dictionaries/)

* Guids
    - you can get [tutorial Link](https://fluentassertions.com/guids/)

* Enums
    - you can get [tutorial Link](https://fluentassertions.com/enums/)

* Exceptions
    - you can get [tutorial Link](https://fluentassertions.com/exceptions/)

