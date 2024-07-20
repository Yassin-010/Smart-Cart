# Smart Shopping Cart Application

## Overview
The Smart Shopping Cart application is a console-based program that simulates shopping at a mall. Users can add and remove items from their shopping cart, view the cart contents, and calculate the total cost of their purchases. The application includes different stores like grocery and clothing stores, each offering a variety of products.

## Features
- **Product Class**: Represents individual items available for purchase with properties like `Name`, `Price`, and `Category`.
- **ShoppingCart Class**: Manages the items added by the user, with methods to add, remove, and view items, as well as calculate the total cost.
- **ProductGenerator Class**: Generates random products with varying attributes for different categories (e.g., food, clothing).
- **Shop Classes**: Represents different stores (e.g., GroceryStore, ClothingStore) with methods to display available products and allow users to select items to add to their cart.
- **User Interface**: Console-based UI to interact with the shopping cart, shop at different stores, view the cart, and check out.

## Lab Specifications
### Product Class
- **File**: `Product.cs`
- **Properties**:
  - `Name`: string
  - `Price`: decimal
  - `Category`: `ProductCategory` enum
- **Enum**: `ProductCategory` (e.g., Food, Clothing, Electronics)

### ShoppingCart Class
- **File**: `ShoppingCart.cs`
- **Methods**:
  - `AddProduct(Product product)`: Adds a product to the cart.
  - `RemoveProduct(string productName)`: Removes a product from the cart by its name.
  - `ViewItems()`: Displays the items in the cart.
  - `CalculateTotalCost()`: Calculates and returns the total cost of items in the cart.

### ProductGenerator Class
- **File**: `ProductGenerator.cs`
- **Methods**:
  - `GenerateGroceryProduct()`: Generates a random grocery product.
  - `GenerateClothingProduct()`: Generates a random clothing product.

### Shop Classes
- **Files**: `GroceryStore.cs`, `ClothingStore.cs`
- **Methods**:
  - `DisplayProducts()`: Displays available products in the store.
  - `SelectProduct(string productName)`: Selects a product by its name.

### User Interface
- **File**: `Program.cs`
- **Main Menu**:
  1. Shop at Grocery Store
  2. Shop at Clothing Store
  3. View Cart
  4. Calculate Total Cost
  5. Check Out and Exit

## Usage
1. **Start the application**: Run the `Program.cs` file.
2. **Navigate the menu**: Use the console to select options and interact with the shopping cart.
3. **Shop at stores**: Add items to your cart from different stores.
4. **View and manage your cart**: View items in your cart and remove items if needed.
5. **Calculate total cost**: Check the total cost of items in your cart.
6. **Check out and exit**: Complete your shopping and exit the application.

## Unit Tests
Unit tests are included to validate the functionality of the ShoppingCart class, including:
- Adding and removing items from the cart.
- Calculating the total cost.

### Running the Tests
1. **Open the Test Explorer**: In Visual Studio, go to `Test` -> `Test Explorer`.
2. **Run the tests**: Run all tests to ensure the application functions as expected.


## Contributing
Contributions are welcome! Please fork the repository and submit a pull request for review.

## License
This project is licensed under the MIT License.

