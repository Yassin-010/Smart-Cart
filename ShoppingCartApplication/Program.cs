namespace ShoppingCartApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();
            ProductGenerator generator = new ProductGenerator();
            GroceryStore groceryStore = new GroceryStore(generator);
            ClothingStore clothingStore = new ClothingStore(generator);

            while (true)
            {
                Console.WriteLine("1. Shop at Grocery Store");
                Console.WriteLine("2. Shop at Clothing Store");
                Console.WriteLine("3. View Your Cart");
                Console.WriteLine("4. Calculate Total Cost");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ShopAtStore(groceryStore, cart);
                        break;
                    case "2":
                        ShopAtStore(clothingStore, cart);
                        break;
                    case "3":
                        cart.ViewItems();
                        Console.Write("Enter the name of the product to remove or press Enter to skip: ");
                        string productName = Console.ReadLine();
                        if (!string.IsNullOrEmpty(productName))
                        {
                            cart.RemoveProduct(productName);
                        }
                        break;
                    case "4":
                        Console.WriteLine($"\n-----------------------------\n" +
                            $"     Total Cost: ${cart.CalculateTotalCost()}" +
                            $"\n-----------------------------");
                        break;
                    case "5":
                        Console.WriteLine("Thank you for shopping with us!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

        static void ShopAtStore(dynamic store, ShoppingCart cart)
        {
            store.DisplayProducts();
            Console.Write("\nEnter the name of the product to add to your cart: ");
            string productName = Console.ReadLine();
            var product = store.SelectProduct(productName);
            if (product != null)
            {
                cart.AddProduct(product);
            }
            else
            {
                Console.WriteLine("Product not found.\n");
            }
        }
    }
}
