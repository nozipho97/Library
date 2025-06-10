using LibraryItem;
using System;
using System.Collections.Generic;

namespace LibraryItem
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryManager manager = new LibraryManager();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n--- Library Manager ---");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Add DVD");
                Console.WriteLine("3. Add Magazine");
                Console.WriteLine("4. Display Items");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter book title: ");
                        string bookTitle = Console.ReadLine();

                        Console.Write("Enter author: ");
                        string author = Console.ReadLine();

                        Book book = new Book
                        {
                            ID = Guid.NewGuid().ToString(),
                            Title = bookTitle,
                            Author = author,
                            YearPublished = DateTime.Now.Year
                        };
                        manager.AddItem(book);
                        Console.WriteLine(" Book added.");
                        break;

                    case "2":
                        Console.Write("Enter DVD title: ");
                        string dvdTitle = Console.ReadLine();

                        Console.Write("Enter duration (minutes): ");
                        int duration = int.Parse(Console.ReadLine());

                        DVD dvd = new DVD
                        {
                            ID = Guid.NewGuid().ToString(),
                            Title = dvdTitle,
                            DurationMinutes = duration,
                            YearPublished = DateTime.Now.Year
                        };
                        manager.AddItem(dvd);
                        Console.WriteLine(" DVD added.");
                        break;

                    case "3":
                        Console.Write("Enter magazine title: ");
                        string magTitle = Console.ReadLine();

                        Console.Write("Enter issue number: ");
                        int issue = int.Parse(Console.ReadLine());

                        Magazine mag = new Magazine
                        {
                            ID = Guid.NewGuid().ToString(),
                            Title = magTitle,
                            IssueNumber = issue,
                            YearPublished = DateTime.Now.Year
                        };
                        manager.AddItem(mag);
                        Console.WriteLine(" Magazine added.");
                        break;

                    case "4":
                        manager.DisplayItems();
                        break;

                    case "5":
                        running = false;
                        break;

                    default:
                        Console.WriteLine(" Invalid option. Try again.");
                        break;
                }
            }

            Console.WriteLine("\n You may exit");
        }
    }

}

