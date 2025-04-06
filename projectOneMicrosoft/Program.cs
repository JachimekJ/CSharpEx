/* 
Inventory management system:

 To complete this challenge, you will need to create a console application where users can manage product stock. Users should be able to add new products, update stock, and remove products.

    Some key features include:
    
    *Add new products with name, price, and stock quantity.
    *Update stock when products are sold or restocked.
    *View all products and their stock levels.
    *Remove products from inventory. */

//Project title: Jachimek Basketball Store - Inventory Management

using System;
using System.Collections.Generic;


//class to represent a product in the inventory
//with properties for name, price, and stock quantity

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }

    public Product(string name, double price, int stock)
    {
        Name = name;
        Price = price;
        Stock = stock;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Price: {Price:C}, Stock: {Stock}";
    }
}

//main program class to manage the inventory
//with methods to add, update, view, and remove products
class Program
{
    static List<Product> inventory = new List<Product>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nJachimek Basketball Store - Inventory Management");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Update Stock");
            Console.WriteLine("3. View Products");
            Console.WriteLine("4. Remove Product");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddProduct();
                    break;
                case "2":
                    UpdateStock();
                    break;
                case "3":
                    ViewProducts();
                    break;
                case "4":
                    RemoveProduct();
                    break;
                case "5":
                    Console.WriteLine("Finish the program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please choose between 1 and 5.");
                    break;
            }
        }
    }

    //method to add a new product to the inventory
    //it prompts the user for product details and creates a new Product object

    static void AddProduct()
    {
        Console.Write("Enter product name: ");
        string name = Console.ReadLine();

        Console.Write("Enter product price: ");
        if (!double.TryParse(Console.ReadLine(), out double price))
        {
            Console.WriteLine("Invalid price. Product not added.");
            return;
        }

        Console.Write("Enter stock quantity: ");
        if (!int.TryParse(Console.ReadLine(), out int stock))
        {
            Console.WriteLine("Invalid stock quantity. Product not added.");
            return;
        }

        inventory.Add(new Product(name, price, stock));
        Console.WriteLine("Product added successfully.");
    }

    //method to update the stock of an existing product
    //it prompts the user for the product name and new stock quantity
    static void UpdateStock()
    {
        Console.Write("Enter product name to update stock: ");
        string name = Console.ReadLine();

        Product product = inventory.Find(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (product == null)
        {
            Console.WriteLine("Product not found.");
            return;
        }

        Console.Write("Enter new stock quantity: ");
        if (!int.TryParse(Console.ReadLine(), out int newStock))
        {
            Console.WriteLine("Invalid stock quantity. Stock not updated.");
            return;
        }

        product.Stock = newStock;
        Console.WriteLine("Stock updated successfully.");
    }

    //method to view all products in the inventory
    //it displays the name, price, and stock quantity of each product
    static void ViewProducts()
    {
        if (inventory.Count == 0)
        {
            Console.WriteLine("No products in inventory.");
            return;
        }

        Console.WriteLine("\nCurrent Inventory:");
        foreach (var product in inventory)
        {
            Console.WriteLine(product);
        }
    }

    //method to remove a product from the inventory
    //it prompts the user for the product name and removes it from the list if found

    static void RemoveProduct()
    {
        Console.Write("Enter product name to remove: ");
        string name = Console.ReadLine();

        Product product = inventory.Find(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (product == null)
        {
            Console.WriteLine("Product not found.");
            return;
        }

        inventory.Remove(product);
        Console.WriteLine("Product removed successfully.");
    }
}