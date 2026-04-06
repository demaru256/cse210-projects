using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Scripture library 
        List<Scripture> scriptures = new List<Scripture>()
        {
            new Scripture(new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son"),
            
            new Scripture(new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding"),
            
            new Scripture(new Reference("Psalm", 23, 1),
                "The Lord is my shepherd; I shall not want")
        };

        // Pick a random scripture
        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            // Creative and Exceeding Requirements: Showing the user how much of the scripture is hidden ( %) after each step.
            Console.WriteLine($"\nProgress: {scripture.GetHiddenPercentage()}% hidden");

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden! Memorization complete!");
                break;
            }

            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            // Hide 3 random words per step
            scripture.HideRandomWords(2);
        }
    }
}