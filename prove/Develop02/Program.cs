using System;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Journal Program Menu:");
            Console.WriteLine("1. Write a New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal to File");
            Console.WriteLine("4. Load Journal from File");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the date (e.g., YYYY-MM-DD): ");
                        string date = Console.ReadLine();
                        string response = "";

                        string[] prompts = {
                            "Who was the most interesting person you interacted with today?",
                            "What was the best part of your day?",
                            "How did you see the hand of the Lord in your life today?",
                            "What was the strongest emotion you felt today?",
                            "If you could do one thing over today, what would it be?"
                        };

                        // Select a random prompt from the array
                        Random random = new Random();
                        int index = random.Next(prompts.Length);
                        string prompt = prompts[index];

                        Console.WriteLine($"Prompt: {prompt}");
                        
                        // Capture the user's response
                        Console.Write("Your response: ");
                        response = Console.ReadLine();

                        journal.AddEntry(date, response, prompt);
                        break;
                    case 2:
                        Console.WriteLine("Displaying Journal Entries:");
                        foreach (var entry in journal.GetEntries())
                        {
                            Console.WriteLine($"Date: {entry.Date}");
                            Console.WriteLine($"Prompt: {entry.Prompt}");
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        Console.Write("Enter the filename to save to: ");
                        string saveFile = Console.ReadLine();
                        journal.SaveToFile(saveFile);
                        break;
                    case 4:
                        Console.Write("Enter the filename to load from: ");
                        string loadFile = Console.ReadLine();
                        journal.LoadFromFile(loadFile);
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid menu option.");
            }
        }
    }
}
