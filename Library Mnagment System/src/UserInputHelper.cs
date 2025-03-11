using System;

static class UserInputHelper
{
    public static string GetNonEmptyString(string prompt)
    {
        string input;
        do
        {
            Console.Write(prompt);
            input = Console.ReadLine()?.Trim();
            if (string.IsNullOrEmpty(input))
                DisplayError("Input cannot be empty. Please try again.");
        } while (string.IsNullOrEmpty(input));

        return input;
    }

    public static int GetValidYear(string prompt)
    {
        int year;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out year) && year >= 1000 && year <= DateTime.Now.Year)
                return year;

            DisplayError("Invalid year. Please enter a valid year.");
        }
    }

    public static int GetValidInt(string prompt)
    {
        int number;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out number))
                return number;

            DisplayError("Invalid input. Please enter a valid number.");
        }
    }

    public static void DisplayError(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    public static void DisplaySuccess(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    public static void DisplayInfo(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(message);
        Console.ResetColor();
    }
}
