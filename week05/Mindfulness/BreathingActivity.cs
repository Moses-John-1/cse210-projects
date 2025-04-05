using System;

class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Activity", "\nThis activity will help you relax by guiding you through \n" + 
        "slow, deep breaths. Clear your mind, focus on your breathing, \n" + 
        "and feel the stress melt away.") {}

    public override void Run()
    {
        DisplayStartingMessage();
        for (int i = 0; i < _duration / 6; i++)
        {
            Console.WriteLine("\nBreathe in...");
            ShowCountDown(3);
            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
        }
        DisplayEndingMessage();
    }
}
