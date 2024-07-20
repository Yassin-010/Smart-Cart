using System;
using System.Collections.Generic;

namespace ShoppingCartApplication
{
    public class GroceryStore
    {
        private List<Product> products;

        public GroceryStore(ProductGenerator generator)
        {
            products = new List<Product>();
            for (int i = 0; i < 10; i++)
            {
                products.Add(generator.GenerateGroceryProduct());
            }
        }

        public void DisplayProducts()
        {
            Console.WriteLine("\n\nProducts available in Grocery Store:\n");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine();
        }

        public Product SelectProduct(string productName)
        {
            return products.Find(p => p.Name == productName);
        }
    }
}
