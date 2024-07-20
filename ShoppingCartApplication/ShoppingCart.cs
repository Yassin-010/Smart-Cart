using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApplication
{
    public class ShoppingCart
    {
        private List<Product> items;

        public ShoppingCart()
        {
            items = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            items.Add(product);
            Console.WriteLine($"{product.Name} added to the cart.\n");
        }

        public void RemoveProduct(string productName)
        {
            foreach (var item in items)
            {
                if (item.Name == productName)
                {
                    var pr = item;
                    items.Remove(pr);
                    Console.WriteLine($"{productName} removed from the cart.\n");
                    return;
                }else
                {
                    Console.WriteLine($"{productName} not found in the cart.\n");
                }
            }
            
        }

        public void ViewItems()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Your cart is empty.\n");
                return;
            }

            Console.WriteLine("Items in your cart:");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        public IEnumerable<Product> GetItems()
        {
            return items;
        }
        public decimal CalculateTotalCost()
        {
            decimal total = 0;
            foreach (var item in items)
            {
                total += item.Price;
            }
            return total;
        }
    }
}
