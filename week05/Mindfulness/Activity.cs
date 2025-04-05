using System;
using System.Threading;

abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\n------Wellcome to {_name}------");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, could you want this sesoan to last?  ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("\n------Prepare to begin------");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\n------Good job! You have completed the activity.------");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        string[] spinnerFrames = { "|", "/", "-", "\\" };
        int spinnerIndex = 0;

        for (int i = seconds; i > 0; i--)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"\r{i} {spinnerFrames[spinnerIndex]} ");
                Thread.Sleep(1000);
                spinnerIndex = (spinnerIndex + 1) % spinnerFrames.Length;
            }
        }
        Console.Write("\r            \r");
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public abstract void Run();
}
