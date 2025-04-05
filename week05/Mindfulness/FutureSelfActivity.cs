using System;
using System.Collections.Generic;
using System.Threading;

class FutureSelfActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public FutureSelfActivity() 
        : base("Future Self Activity", "\nThis activity will help you visualize your future self to gain clarity and motivation. \n"+
        "Imagine what they’d thank you for doing today.")
    {
        _prompts = new List<string>
        {
            "Imagine meeting yourself 5 years from now. What do they say about your choices today?",
            "Picture your future self after achieving your goals. What daily habits helped you get there?",
            "Visualize your future self looking back at today. What do they thank you for doing now?"
        };

        _questions = new List<string>
        {
            "What’s one thing your future self warns you not to neglect?",
            "What habit should you start today that your future self will appreciate?",
            "What current challenge will your future self be proud you overcame?",
            "What is your future self doing every day to stay fulfilled?",
            "What do you need to stop doing to become that future version of yourself?"
        };
    }

    public override void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nReflect on this prompt:");
        Console.WriteLine($"> {_prompts[new Random().Next(_prompts.Count)]}");
        ShowSpinner(5);

        Console.WriteLine("\nNow, consider these questions:");
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"> {_questions[i % _questions.Count]}");
            ShowSpinner(8);
            i++;
        }

        DisplayEndingMessage();
    }
}
