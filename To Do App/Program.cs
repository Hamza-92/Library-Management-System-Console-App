using System;
using System.Collections.Generic;

class Program
{
    static List<string> tasks = new List<string>();
    static List<bool> taskStatus = new List<bool>(); // true = done, false = not done

    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("          TO-DO LIST APP           ");
        Console.WriteLine("-----------------------------------");
        Console.ResetColor();

        while (true)
        {
            Console.WriteLine("\nOptions:");
            Console.WriteLine("[1] Add Task");
            Console.WriteLine("[2] View Tasks");
            Console.WriteLine("[3] Mark Task as Done");
            Console.WriteLine("[4] Remove Task");
            Console.WriteLine("[5] Exit");

            Console.Write("\nSelect an option: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int choice) || choice < 1 || choice > 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input! Please enter a number between 1 and 5.");
                Console.ResetColor();
                continue;
            }

            switch (choice)
            {
                case 1:
                    AddTask();
                    break;
                case 2:
                    ViewTasks();
                    break;
                case 3:
                    MarkTaskDone();
                    break;
                case 4:
                    RemoveTask();
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\nExiting... All tasks saved.");
                    Console.ResetColor();
                    return;
            }
        }
    }

    static void AddTask()
    {
        Console.Write("Enter task description: ");
        string task = Console.ReadLine()?.Trim();
        if (string.IsNullOrWhiteSpace(task))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Task cannot be empty!");
            Console.ResetColor();
            return;
        }
        tasks.Add(task);
        taskStatus.Add(false);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Task added successfully.");
        Console.ResetColor();
    }

    static void ViewTasks()
    {
        if (tasks.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("No tasks available.");
            Console.ResetColor();
            return;
        }

        Console.WriteLine("\nYour Tasks:");
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.ForegroundColor = taskStatus[i] ? ConsoleColor.Green : ConsoleColor.Yellow;
            Console.WriteLine($"{i + 1}. {tasks[i]} - [{(taskStatus[i] ? "Done" : "Not Done")}]");
            Console.ResetColor();
        }
    }

    static void MarkTaskDone()
    {
        ViewTasks();
        Console.Write("Enter task number to mark as done: ");
        if (!int.TryParse(Console.ReadLine(), out int index) || index < 1 || index > tasks.Count)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid task number.");
            Console.ResetColor();
            return;
        }

        taskStatus[index - 1] = true;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Task marked as done.");
        Console.ResetColor();
    }

    static void RemoveTask()
    {
        ViewTasks();
        Console.Write("Enter task number to remove: ");
        if (!int.TryParse(Console.ReadLine(), out int index) || index < 1 || index > tasks.Count)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid task number.");
            Console.ResetColor();
            return;
        }

        tasks.RemoveAt(index - 1);
        taskStatus.RemoveAt(index - 1);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Task removed successfully.");
        Console.ResetColor();
    }
}
