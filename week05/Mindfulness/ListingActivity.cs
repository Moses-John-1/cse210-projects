using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "List things that make you happy.",
        "List people who inspire you.",
        "List your achievements in the past year.",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?"

    };

    public ListingActivity() 
        : base("Listing Activity", "\nThis activity invites you to reflect on the positive aspects of your life, \n"+
        "it will help you focus on what brings you joy and gratitude.") { }

    public override void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine("\n" + prompt);
        ShowCountDown(5);
        List<string> userResponses = GetListFromUser();
        Console.WriteLine($"\nYou listed {userResponses.Count} items.");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    private List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        Console.WriteLine("Start listing (press Enter after each item, type 'done' to finish):");
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done") break;
            responses.Add(input);
        }
        return responses;
    }
}
