class Program
{
    static void Main()
    {
        Library library = new Library();

        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("========================");
            Console.WriteLine("   Library Management   ");
            Console.WriteLine("========================");
            Console.ResetColor();
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. View Books");
            Console.WriteLine("3. Borrow Book");
            Console.WriteLine("4. Return Book");
            Console.WriteLine("5. Remove Book");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");

            switch (Console.ReadLine()?.Trim())
            {
                case "1": library.AddBook(); break;
                case "2": library.ViewBooks(); break;
                case "3": library.BorrowBook(); break;
                case "4": library.ReturnBook(); break;
                case "5": library.RemoveBook(); break;
                case "6": return;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.ResetColor();
                    break;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}