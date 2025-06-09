using System;
using System.Collections.Generic;

namespace LibraryManager
{

    class Program
    {
        static List<LibraryItem> libraryItems = new List<LibraryItem>();

        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nLibrary Management System");
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. Remove Item");
                Console.WriteLine("3. Search Item");
                Console.WriteLine("4. Display All Items");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                try
                {
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            AddItem();
                            break;
                        case 2:
                            RemoveItem();
                            break;
                        case 3:
                            SearchItem();
                            break;
                        case 4:
                            DisplayAllItems();
                            break;
                        case 5:
                            running = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Try again.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
        }

        static void AddItem()
        {
            Console.WriteLine("Select item type: 1. Book 2. Magazine 3. DVD");
            string typeChoice = Console.ReadLine();
            Console.Write("Enter ID: ");
            string id = Console.ReadLine();
            Console.Write("Enter Title: ");
            string title = Console.ReadLine();
            Console.Write("Enter Year Published: ");

            if (!int.TryParse(Console.ReadLine(), out int year))
            {
                Console.WriteLine("Invalid year. Operation cancelled.");
                return;
            }

            switch (typeChoice)
            {
                case "1":
                    Console.Write("Enter Author: ");
                    string author = Console.ReadLine();
                    Console.Write("Enter Genre: ");
                    string genre = Console.ReadLine();
                    libraryItems.Add(new Book { ID = id, title = title, YearPublished = year, Author = author, Genre = genre });
                    break;
                case "2":
                    Console.Write("Enter Issue Number: ");
                    if (!int.TryParse(Console.ReadLine(), out int issueNumber))
                    {
                        Console.WriteLine("Invalid issue number.");
                        return;
                    }
                    Console.Write("Enter Month: ");
                    string month = Console.ReadLine();
                    libraryItems.Add(new Magazine { ID = id, title = title, YearPublished = year, IssueNumber = issueNumber, Month = month });
                    break;
                case "3":
                    Console.Write("Enter Director: ");
                    string director = Console.ReadLine();
                    Console.Write("Enter Duration in hours: ");
                    if (!double.TryParse(Console.ReadLine(), out double duration))
                    {
                        Console.WriteLine("Invalid duration.");
                        return;
                    }
                    libraryItems.Add(new DVD { ID = id, title = title, YearPublished = year, Director = director, Duration = duration });
                    break;
                default:
                    Console.WriteLine("Invalid item type.");
                    break;
            }
        }

        static void RemoveItem()
        {
            Console.Write("Enter the ID of the item to remove: ");
            string id = Console.ReadLine();
            var item = libraryItems.Find(i => i.ID == id);
            if (item != null)
            {
                libraryItems.Remove(item);
                Console.WriteLine("Item removed successfully.");
            }
            else
            {
                Console.WriteLine("Item not found.");
            }
        }

        static void SearchItem()
        {
            Console.Write("Enter the ID of the item to search: ");
            string id = Console.ReadLine();
            var item = libraryItems.Find(i => i.ID == id);
            if (item != null)
            {
                Console.WriteLine("Item found:");
                item.Display();
            }
            else
            {
                Console.WriteLine("Item not found.");
            }
        }

        static void DisplayAllItems()
        {
            if (libraryItems.Count == 0)
            {
                Console.WriteLine("No items in the library.");
                return;
            }

            Console.WriteLine("\nLibrary Items:");
            foreach (var item in libraryItems)
            {
                item.Display();
            }
        }
    }
}

