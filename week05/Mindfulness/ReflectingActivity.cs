using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you helped someone.",
        "Think of a time when you did something difficult.",
        "Think of a time when you stood up for someone.",
        "Think of a time when you did something selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful?",
        "Have you done anything like this before?",
        "How did you get started?",
        "How did you feel when it was finished?",
        "What did you learn about yourself?"
    };

    public ReflectingActivity()
        : base("Reflection",
        "This activity helps you reflect on times when you showed strength.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine("\nConsider the following prompt:\n");
        Console.WriteLine($"--- {prompt} ---");

        Console.WriteLine("\nPress Enter when ready.");
        Console.ReadLine();

        Console.WriteLine("\nNow reflect on these questions:");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = _questions[rand.Next(_questions.Count)];

            Console.WriteLine($"\n{question}");
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }
}