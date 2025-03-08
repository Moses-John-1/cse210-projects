using System;

class Program
{
    static void Main(string[] args)

    {
        string playAgain;
        do
        {
            // Generating Random Numbers
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guessNumber = -1;
            int guessNumberCount = 0;

            // checking if the guess number is equal magic number
            while (guessNumber != magicNumber)
            {
                Console.Write("What is the guess? ");
                string guess = Console.ReadLine();
                guessNumber = int.Parse(guess);

                guessNumberCount++; // counting time of trial

                if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }

                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
            }
            // writing out result
            Console.WriteLine($"You guessed it in {guessNumberCount} tries! ");

            // checking if user want to play again
            Console.WriteLine("Do you want play again? (yes/no)");
            playAgain = Console.ReadLine().ToLower();
        }

        while (playAgain == "yes");

        Console.WriteLine("Thank you for playing, Goodbye");
            
               
    }
}


