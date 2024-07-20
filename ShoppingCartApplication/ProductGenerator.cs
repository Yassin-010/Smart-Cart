using System;

namespace ShoppingCartApplication
{
    public class ProductGenerator
    {
        private static readonly Random random = new Random();

        private static readonly string[] groceryProductNames = {
            "Apple", "Banana", "Orange", "Milk", "Bread", "Cheese"
        };

        private static readonly string[] clothingProductNames = {
            "Jeans", "T-Shirt", "Jacket", "Sweater", "Socks", "Shoes"
        };

        public Product GenerateGroceryProduct()
        {
            string name = groceryProductNames[random.Next(groceryProductNames.Length)];
            decimal price = (decimal)(random.Next(100, 1001)) / 100;
            ProductCategory category = ProductCategory.Food;

            return new Product(name, price, category);
        }

        public Product GenerateClothingProduct()
        {
            string name = clothingProductNames[random.Next(clothingProductNames.Length)];
            decimal price = (decimal)(random.Next(1000, 10001)) / 100;
            ProductCategory category = ProductCategory.Clothing;

            return new Product(name, price, category);
        }
    }
}
