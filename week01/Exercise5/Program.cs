using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();
        
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        
        int squareNumber = SquareNumber(userNumber);
        
        DisplayResult(userName, squareNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int squareNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squareNumber}");
    }
}