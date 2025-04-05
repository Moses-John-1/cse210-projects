// I added the FutureSelfActivity class as an extra feature beyond the project requirements.
// This activity encourage self-reflection by helping the users visualize their future self and receive imagined advice.
// It use randomized prompts and timed questions to guide deep thinking and motivation.

using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("\nMindfulness Activities");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. FutureSelfActivity");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            
            string choice = Console.ReadLine();
            Activity activity = choice switch
            {
                "1" => new BreathingActivity(),
                "2" => new ListingActivity(),
                "3" => new ReflectingActivity(),
                "4" => new FutureSelfActivity(),
                "5"=> null,
                _ => null
            };

            if (activity == null)
                break;

            Console.Clear();
            activity.Run();
            Console.WriteLine("\nPress any key to return to the menu...");
            Console.ReadKey();
        }
    }
}
