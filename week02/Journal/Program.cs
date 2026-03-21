using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            string input = Console.ReadLine();

            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            if (choice == 1)
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine($"\nPrompt: {prompt}");
                Console.Write("> ");
                string response = Console.ReadLine();

                Entry entry = new Entry
                {
                    _date = DateTime.Now.ToShortDateString(),
                    _promptText = prompt,
                    _entryText = response
                };

                journal.AddEntry(entry);
                Console.WriteLine("Entry added.");
            }
            else if (choice == 2)
            {
                Console.WriteLine("\nYour Journal Entries:");
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("\nEnter filename to save: ");
                string file = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(file))
                {
                    journal.SaveToFile(file);
                    Console.WriteLine("Journal saved.");
                }
                else
                {
                    Console.WriteLine("Invalid filename.");
                }
            }
            else if (choice == 4)
            {
                Console.Write("\nEnter filename to load: ");
                string file = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(file))
                {
                    journal.LoadFromFile(file);
                    Console.WriteLine("Journal loaded.");
                }
                else
                {
                    Console.WriteLine("Invalid filename.");
                }
            }
            else if (choice == 5)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Try again.");
            }
        }
    }
}