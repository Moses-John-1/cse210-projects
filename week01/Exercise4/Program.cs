using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;

        // Getting user input

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter Number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }

        }
        while (number != 0);

        if (numbers.Count > 0)
        {

            int sum = 0;
            int maximumNumber = numbers[0];

            foreach (int num in numbers)
            {
                sum += num;

                if (num > maximumNumber)
                {
                    maximumNumber = num;
                }
            }
            // calculation here
            double average = (double)sum / numbers.Count;

            Console.WriteLine($"The Sum is: {sum}");
            Console.WriteLine($"The Average is: {average}");
            Console.WriteLine($"The Largest Number is: {maximumNumber}");
        }
        
    }
}