using System;
using System.Collections.Generic;

class Library
{
    private List<Book> books = new List<Book>();
    private int bookCounter = 1;

    public void AddBook()
    {
        try
        {
            Console.Write("\nEnter book title: ");
            string title = Console.ReadLine().Trim();
            Console.Write("Enter author name: ");
            string author = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author))
            {
                Console.WriteLine("Error: Title and Author cannot be empty!\n");
                return;
            }

            books.Add(new Book { Id = bookCounter++, Title = title, Author = author });
            Console.WriteLine("\nBook added successfully!\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}\n");
        }
    }

    public void ViewBooks()
    {
        Console.WriteLine("\n=== Library Books ===");
        if (books.Count == 0)
        {
            Console.WriteLine("No books available in the library.\n");
            return;
        }
        Console.WriteLine("ID   | Title                         | Author             | Status");
        Console.WriteLine("------------------------------------------------------------");
        foreach (var book in books)
        {
            Console.WriteLine($"{book.Id,-4} | {book.Title,-30} | {book.Author,-20} | {(book.IsBorrowed ? "Borrowed" : "Available")}");
        }
        Console.WriteLine();
    }

    public void BorrowBook()
    {
        try
        {
            Console.Write("\nEnter book ID to borrow: ");
            if (int.TryParse(Console.ReadLine(), out int bookId))
            {
                var book = books.Find(b => b.Id == bookId);
                if (book != null && !book.IsBorrowed)
                {
                    book.IsBorrowed = true;
                    Console.WriteLine("\nBook borrowed successfully!\n");
                }
                else
                {
                    Console.WriteLine("\nError: Invalid ID or book already borrowed.\n");
                }
            }
            else
            {
                Console.WriteLine("\nError: Invalid input! Please enter a valid book ID.\n");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}\n");
        }
    }

    public void ReturnBook()
    {
        try
        {
            Console.Write("\nEnter book ID to return: ");
            if (int.TryParse(Console.ReadLine(), out int bookId))
            {
                var book = books.Find(b => b.Id == bookId);
                if (book != null && book.IsBorrowed)
                {
                    book.IsBorrowed = false;
                    Console.WriteLine("\nBook returned successfully!\n");
                }
                else
                {
                    Console.WriteLine("\nError: Invalid ID or book was not borrowed.\n");
                }
            }
            else
            {
                Console.WriteLine("\nError: Invalid input! Please enter a valid book ID.\n");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}\n");
        }
    }

    public void RemoveBook()
    {
        try
        {
            Console.Write("\nEnter book ID to remove: ");
            if (int.TryParse(Console.ReadLine(), out int bookId))
            {
                var book = books.Find(b => b.Id == bookId);
                if (book != null)
                {
                    books.Remove(book);
                    Console.WriteLine("\nBook removed successfully!\n");
                }
                else
                {
                    Console.WriteLine("\nError: Book not found.\n");
                }
            }
            else
            {
                Console.WriteLine("\nError: Invalid input! Please enter a valid book ID.\n");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}\n");
        }
    }
}