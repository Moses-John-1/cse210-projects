using System;
using System.Collections.Generic;

/* This program exceeds the assignment requirements by implementing a Scripture Library feature.
   Instead of working with a single scripture, it randomly selects scriptures from a list.
   After completing one scripture, the user is asked if they want to continue with another.
   If they choose "yes," a new scripture is randomly selected, and the process restarts.
   This makes the program more interactive and engaging.
 */


class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son"),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ who strengthens me."),
            new Scripture(new Reference("Psalm", 23, 1), "The Lord is my shepherd; I shall not want.")
        };

        Random random = new Random();
        bool continueProgram = true;

        while (continueProgram)
        {
            Scripture scripture = scriptures[random.Next(scriptures.Count)]; 

            while (!scripture.AllWordsHidden())
            {
                Console.Clear();
                scripture.Display();
                Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

                string input = Console.ReadLine();
                if (input.ToLower() == "quit") return;

                scripture.HideRandomWords(2);
            }

            Console.Clear();
            scripture.Display();
            Console.WriteLine("\nAll words are hidden.");

            /* I ask user if they want to continue */
            Console.WriteLine("\nWould you like to start another scripture? (yes/no)");
            string response = Console.ReadLine().ToLower();
            continueProgram = (response == "yes");
        }

        Console.WriteLine("\nThank you for using the Scripture Memorizer! Goodbye.");
    }
}
