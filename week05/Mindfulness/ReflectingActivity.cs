using System;
using System.Collections.Generic;

class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think about a time you overcame a challenge.",
        "Recall a moment when you felt truly at peace.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you helped someone in need."

    };

    private List<string> _questions = new List<string>
    {
        "What did you learn from this experience?",
        "How did this experience make you stronger?",
        "How did you get started?",
        "What could you learn from this experience that applies to other situations?",
        "What is your favorite thing about this experience?"
    };

    public ReflectingActivity() 
        : base("Reflecting Activity", "\nThis activity helps you reflect on times you have shown true strength and resilience, \n "+
        "reminding you of the power within you to overcome anything and grow in every part of your life.") { }

    public override void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine("\nReflect on this: " + prompt);
        ShowCountDown(5);
        DisplayQuestions();
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    private void DisplayQuestions()
    {
        foreach (string question in _questions)
        {
            Console.WriteLine(question);
            ShowSpinner(5);
        }
    }
}
