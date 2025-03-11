using System;
using System.Collections.Generic;

class Library
{
    private List<Book> books;
    private int nextId;

    public Library()
    {
        books = StorageManager.LoadBooks();
        nextId = books.Count > 0 ? books[^1].Id + 1 : 1;
    }

    public void AddBook()
    {
        Console.Clear();
        Console.WriteLine("=== Add New Book ===");

        string title = UserInputHelper.GetNonEmptyString("Enter Book Title: ");
        string author = UserInputHelper.GetNonEmptyString("Enter Author: ");
        int year = UserInputHelper.GetValidYear("Enter Publish Year: ");

        if (books.Exists(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase) &&
                              b.Author.Equals(author, StringComparison.OrdinalIgnoreCase)))
        {
            UserInputHelper.DisplayError("This book already exists in the library.");
            return;
        }

        books.Add(new Book { Id = nextId++, Title = title, Author = author, PublishYear = year, IsBorrowed = false });
        StorageManager.SaveBooks(books);

        UserInputHelper.DisplaySuccess("Book added successfully!");
    }

    public void ViewBooks()
    {
        Console.Clear();
        Console.WriteLine("=== Library Books ===");
        DisplayBooks(books);
    }

    public void BorrowBook()
    {
        Console.Clear();
        Console.WriteLine("=== Borrow a Book ===");
        List<Book> availableBooks = books.FindAll(b => !b.IsBorrowed);

        if (availableBooks.Count == 0)
        {
            UserInputHelper.DisplayError("No available books to borrow.");
            return;
        }

        DisplayBooks(availableBooks);

        int id = UserInputHelper.GetValidInt("Enter Book ID to Borrow: ");
        Book book = books.Find(b => b.Id == id && !b.IsBorrowed);

        if (book != null)
        {
            book.IsBorrowed = true;
            StorageManager.SaveBooks(books);
            UserInputHelper.DisplaySuccess($"Book '{book.Title}' borrowed successfully!");
        }
        else
        {
            UserInputHelper.DisplayError("Invalid book ID or book is already borrowed.");
        }
    }

    public void ReturnBook()
    {
        Console.Clear();
        Console.WriteLine("=== Return a Book ===");
        List<Book> borrowedBooks = books.FindAll(b => b.IsBorrowed);

        if (borrowedBooks.Count == 0)
        {
            UserInputHelper.DisplayError("No books are currently borrowed.");
            return;
        }

        DisplayBooks(borrowedBooks);

        int id = UserInputHelper.GetValidInt("Enter Book ID to Return: ");
        Book book = books.Find(b => b.Id == id && b.IsBorrowed);

        if (book != null)
        {
            book.IsBorrowed = false;
            StorageManager.SaveBooks(books);
            UserInputHelper.DisplaySuccess($"Book '{book.Title}' returned successfully!");
        }
        else
        {
            UserInputHelper.DisplayError("Invalid book ID or the book was not borrowed.");
        }
    }

    public void RemoveBook()
    {
        Console.Clear();
        Console.WriteLine("=== Remove a Book ===");

        if (books.Count == 0)
        {
            UserInputHelper.DisplayError("No books available to remove.");
            return;
        }

        DisplayBooks(books);

        int id = UserInputHelper.GetValidInt("Enter Book ID to Remove: ");
        Book book = books.Find(b => b.Id == id);

        if (book != null)
        {
            Console.Write($"Are you sure you want to remove '{book.Title}'? (y/n): ");
            string confirmation = Console.ReadLine()?.Trim().ToLower();

            if (confirmation == "y")
            {
                books.Remove(book);
                StorageManager.SaveBooks(books);
                UserInputHelper.DisplaySuccess("Book removed successfully!");
            }
            else
            {
                UserInputHelper.DisplayInfo("Book removal canceled.");
            }
        }
        else
        {
            UserInputHelper.DisplayError("Book not found.");
        }
    }

    private void DisplayBooks(List<Book> bookList)
    {
        if (bookList.Count == 0)
        {
            Console.WriteLine("No books found.");
            return;
        }

        Console.WriteLine("====================================================================================");
        Console.WriteLine("| ID  | Title                          | Author                | Year   | Status     |");
        Console.WriteLine("====================================================================================");

        foreach (var book in bookList)
        {
            Console.WriteLine($"| {book.Id,-3} | {book.Title,-30} | {book.Author,-20} | {book.PublishYear,-6} | {(book.IsBorrowed ? "Borrowed" : "Available"),-10} |");
        }

        Console.WriteLine("====================================================================================");
    }
}
