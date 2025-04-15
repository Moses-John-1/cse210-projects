using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2024, 10, 3), 30, 3.0),
            new Cycling(new DateTime(2024, 10, 3), 45, 20.0),
            new Swimming(new DateTime(2024, 10, 3), 40, 50)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}