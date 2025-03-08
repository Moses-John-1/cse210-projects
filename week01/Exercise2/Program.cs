using System;

class Program
{
    static void Main(string[] args)
    {
        // geting user input
        Console.Write("Enter you grade percentage: ");
        string grade = Console.ReadLine();
        int UserGrade = int.Parse(grade);

        // determing grade
        string letter = "";

        if (UserGrade >= 90)
        {
            letter = "A";
        }

        else if (UserGrade >= 80)
        {
            letter = "B";
        }

        else if (UserGrade >= 70)
        {
            letter = "C";
        }

        else if (UserGrade >= 60)
        {
            letter = "D";
        }

        else if (UserGrade < 60)
        {
            letter = "F";
        }

        // determing if it positive or negative grade
        int lastDigit = UserGrade % 10;
        string sign = "";

        if (lastDigit >= 7)
        {
            sign = "+";
        }

        else if (lastDigit < 3)
        {
            sign = "-";
        }

        else
        {
            sign = "";
        }

        // Checking for +A, +F and -F
        if (letter == "A" && lastDigit >= 7)
        {
            sign = "";
        }

        else if (letter == "F")
        {
            sign = "";
        }

        // Writing out user grade
        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (UserGrade >= 70)
        {
            Console.WriteLine("Congratulations you have passed the course");
        }

        else
        {
            Console.WriteLine("Sorry you did not pass the course try again next time");
        }
    }
}