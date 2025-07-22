using System;
using System.Collections.Generic;

class basket
{
    static void Main()
    {
        // Main category dictionary
        Dictionary<int, string> categories = new Dictionary<int, string>()
        {
            { 1, "Fruits and Vegetables" },
            { 2, "Bakery and Cakes" },
            { 3, "Instant and Frozen Foods" },
            { 4, "Chocolates and Icecreams" },
            { 5, "Detergents and Cleaning" },
            { 6, "Electronic Stores" }
        };

        // Nested product dictionary: category ID ➜ list of items
        Dictionary<int, List<string>> products = new Dictionary<int, List<string>>();

        // Loop through each category and read inner products
        foreach (var category in categories)
        {
            Console.WriteLine($"\nEnter items for category: {category.Value}");
            Console.Write("How many items do you want to add? ");
            int count = int.Parse(Console.ReadLine());

            List<string> items = new List<string>();
            for (int i = 1; i <= count; i++)
            {
                Console.Write($"Item {i}: ");
                string itemName = Console.ReadLine();
                items.Add(itemName);
            }

            products.Add(category.Key, items);
        }

        // Display full catalog
        Console.WriteLine("\n📦 Product Catalog:");
        foreach (var category in categories)
        {
            Console.WriteLine($"\n{category.Value}:");
            foreach (var item in products[category.Key])
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}