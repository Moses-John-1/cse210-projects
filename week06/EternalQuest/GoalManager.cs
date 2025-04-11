using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        string choice;
        do
        {
            Console.WriteLine($"\n Congratulations! You have {_score} points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoals(); break;
                case "3": SaveGoals(); break;
                case "4": LoadGoals(); break;
                case "5": RecordEvent(); break;
            }

        } while (choice != "6");
    }

    private void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Timed Goal");
        Console.Write("Which type of goal would you like to create? ");
        string input = Console.ReadLine();

        Console.Write("What is the goal name: ");
        string name = Console.ReadLine();

        Console.Write("What is the short description of your goal: ");
        string desc = Console.ReadLine();

        Console.Write("Enter the amount of points you want to earn: ");
        int points = int.Parse(Console.ReadLine());

        switch (input)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, desc, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, desc, points));
                break;
            case "3":
                Console.Write("How many times  do you want to complete? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("How many bonus points: ");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                break;
            case "4":
                Console.Write("Enter deadline (yyyy-mm-dd): ");
                DateTime deadline = DateTime.Parse(Console.ReadLine());

                _goals.Add(new TimedGoal(name, desc, points, deadline));
                break;
        }
    }

    private void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    private void SaveGoals()
    {
        Console.Write("Enter file name: ");
        string file = Console.ReadLine();

        using (StreamWriter output = new StreamWriter(file))
        {
            output.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    private void LoadGoals()
    {
        Console.Write("Enter file name: ");
        string file = Console.ReadLine();

        _goals.Clear();
        string[] lines = File.ReadAllLines(file);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");
            string type = parts[0];

            if (type == "SimpleGoal")
                _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])) { });
            else if (type == "EternalGoal")
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            else if (type == "ChecklistGoal")
                _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5])));
            else if (type == "TimedGoal")
                _goals.Add(new TimedGoal(parts[1], parts[2], int.Parse(parts[3]), DateTime.Parse(parts[4])));
        }
    }

    private void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish?");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        Console.Write("Enter number: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        int points = _goals[index].RecordEvent();
        Console.WriteLine($"You earned {points} points!");
        _score += points;
    }
}
