using ShoppingCartApplication;

namespace ShoppingCartApplicationTests
{
    public class UnitTest1
    {
        [Fact]
        public void AddProduct_ShouldAddProductToCart()
        {
            // Arrange
            var cart = new ShoppingCart();
            var product = new Product("Apple", 1.00m, ProductCategory.Food);

            // Act
            cart.AddProduct(product);

            // Assert
            Assert.Contains(product, cart.GetItems());
        }

        [Fact]
        public void RemoveProduct_ShouldRemoveProductFromCart()
        {
            // Arrange
            var cart = new ShoppingCart();
            var product = new Product("Apple", 1.00m, ProductCategory.Food);
            cart.AddProduct(product);

            // Act
            cart.RemoveProduct(product.Name);

            // Assert
            Assert.DoesNotContain(product, cart.GetItems());
        }

        [Fact]
        public void CalculateTotalCost_ShouldReturnCorrectTotal()
        {
            // Arrange
            var cart = new ShoppingCart();
            cart.AddProduct(new Product("Apple", 1.00m, ProductCategory.Food));
            cart.AddProduct(new Product("Jeans", 20.00m, ProductCategory.Clothing));

            // Act
            var totalCost = cart.CalculateTotalCost();

            // Assert
            Assert.Equal(21.00m, totalCost);
        }
    }
}