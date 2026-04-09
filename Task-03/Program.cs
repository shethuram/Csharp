using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> items = new List<string>();

        while (true)
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Remove Item (by name)");
            Console.WriteLine("3. Remove Item (by index)");
            Console.WriteLine("4. Display Items");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddItem(items);
                    break;

                case "2":
                    RemoveByName(items);
                    break;

                case "3":
                    RemoveByIndex(items);
                    break;

                case "4":
                    DisplayItems(items);
                    break;

                case "5":
                    Console.WriteLine("Exiting program...");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    //  Add Item
    static void AddItem(List<string> items)
    {
        Console.Write("Enter item: ");
        string input = Console.ReadLine()?.Trim().ToUpper();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Invalid input. Cannot add empty item.");
            return;
        }

        if (items.Contains(input))
        {
            Console.WriteLine("Item already exists. Duplicate not allowed.");
            return;
        }

        items.Add(input);
        Console.WriteLine($"Item '{input}' added successfully.");
    }

    //  Remove by Name
    static void RemoveByName(List<string> items)
    {
        if (items.Count == 0)
        {
            Console.WriteLine("List is empty. Nothing to remove.");
            return;
        }

        Console.Write("Enter item to remove: ");
        string input = Console.ReadLine()?.Trim().ToUpper();

        if (items.Remove(input))
        {
            Console.WriteLine($"Item '{input}' removed successfully.");
        }
        else
        {
            Console.WriteLine("Item not found.");
        }
    }

    //  Remove by Index
    static void RemoveByIndex(List<string> items)
    {
        if (items.Count == 0)
        {
            Console.WriteLine("List is empty. Nothing to remove.");
            return;
        }

        DisplayItems(items);

        Console.Write("Enter index to remove: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int index))
        {
            if (index >= 1 && index <= items.Count)
            {
                string removedItem = items[index - 1];
                items.RemoveAt(index - 1);
                Console.WriteLine($"Item '{removedItem}' removed successfully.");
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }
    }

    //  Display Items
    static void DisplayItems(List<string> items)
    {
        if (items.Count == 0)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        Console.WriteLine("\nItems:");
        for (int i = 0; i < items.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {items[i]}");
        }
    }
}