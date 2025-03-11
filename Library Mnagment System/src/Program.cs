using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        Library library = new Library();
        while (true)
        {
            Console.WriteLine("\n========================");
            Console.WriteLine(" Library Management System ");
            Console.WriteLine("========================");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. View Books");
            Console.WriteLine("3. Borrow Book");
            Console.WriteLine("4. Return Book");
            Console.WriteLine("5. Remove Book");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");

            try
            {
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            library.AddBook();
                            break;
                        case 2:
                            library.ViewBooks();
                            break;
                        case 3:
                            library.BorrowBook();
                            break;
                        case 4:
                            library.ReturnBook();
                            break;
                        case 5:
                            library.RemoveBook();
                            break;
                        case 6:
                            Console.WriteLine("\nExiting the program...\n");
                            return;
                        default:
                            Console.WriteLine("\nError: Invalid choice! Please select a valid option.\n");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nError: Invalid input! Please enter a number.\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}\n");
            }
        }
    }
}