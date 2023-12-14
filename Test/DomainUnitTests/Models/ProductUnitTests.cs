using FluentAssertions;

namespace DomainUnitTests.Models
{
    public class ProductUnitTests
    {
        [Theory]
        [InlineData(-10000)]
        [InlineData(0)]
        public void should_not_create_when_price_is_zero_or_less(decimal price)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var product = new Domain.Models.Product.Product("Mobile", price);
            });
        }

        [Fact]
        public void should_be_created_valid_product()
        {
            string name = "Computer";
            decimal price = 100000000;

            var product = new Domain.Models.Product.Product(name, price);

            string expectedName = "Computer";
            decimal expectedPrice = 100000000;

            product.Name.Should().Be(expectedName);
            product.Price.Should().Be(expectedPrice);
        }

        [Fact]
        public void should_be_created_product_correctely()
        {
            string name = "Computer";
            decimal price = 100000000;

            var product = new Domain.Models.Product.Product(name, price);
            product.Update("Mobile", 400000);

            string expectedName = "Mobile";
            decimal expectedPrice = 400000;

            product.Name.Should().Be(expectedName);
            product.Price.Should().Be(expectedPrice);
        }
    }
}
