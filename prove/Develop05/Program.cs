using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Program
{
    private const string FILENAME = "goals.txt"; // the filename to save/load goals

    private static List<Goal> goals = new List<Goal>(); // the list of goals

    public static void Main()
    {
        LoadGoals(); // load the goals from file

        while (true)
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. View goals");
            Console.WriteLine("2. Create a new goal");
            Console.WriteLine("3. Record an event");
            Console.WriteLine("4. Save goals and exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ViewGoals();
                    break;
                case 2:
                    CreateGoal();
                    break;
                case 3:
                    RecordEvent();
                    break;
                case 4:
                    SaveGoals();
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }

    private static void ViewGoals()
    {
        Console.WriteLine("Goals:");

        foreach (Goal goal in goals)
        {
            Console.WriteLine($"{goal.GetStatus()} {goal.Name} ({goal.Score} points)");
        }
    }

    private static void CreateGoal()
    {
        Console.WriteLine("What kind of goal do you want to create?");
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checklist goal");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                CreateSimpleGoal();
                break;
            case 2:
                CreateEternalGoal();
                break;
            case 3:
                CreateChecklistGoal();
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }

    private static void CreateSimpleGoal()
    {
        Console.WriteLine("Enter the name of the goal:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the value of the goal:");
        int value = int.Parse(Console.ReadLine());

        SimpleGoal goal = new SimpleGoal
        {
            Name = name,
            Value = value,
            IsCompleted = false,
            Score = 0
        };

        goals.Add(goal);

        Console.WriteLine($"Simple goal \"{name}\" created");
    }

    private static void CreateEternalGoal()
    {
        Console.WriteLine("Enter the name of the goal:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the value of each completion:");
        int value = int.Parse(Console.ReadLine());

        EternalGoal goal = new EternalGoal
        {
            Name = name,
            Value = value,
            Score = 0
        };

        goals.Add(goal);

        Console.WriteLine($"Eternal goal \"{name}\" created");
    }

    private static void CreateChecklistGoal()
{
    Console.WriteLine("Enter the name of the goal:");
    string name = Console.ReadLine();

    Console.WriteLine("Enter the value of each completion:");
    int value = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the required number of completions:");
    int required = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the bonus value for completion:");
    int bonus = int.Parse(Console.ReadLine());

    ChecklistGoal goal = new ChecklistGoal
    {
        Name = name,
        Value = value,
        TimesCompleted = 0,
        RequiredTimes = required,
        Bonus = bonus,
        Score = 0
    };

    goals.Add(goal);
}


private static void RecordEvent()
{
    Console.WriteLine("Which goal did you complete?");
    string name = Console.ReadLine();

    Goal goal = goals.FirstOrDefault(g => g.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

    if (goal == null)
    {
        Console.WriteLine($"Goal \"{name}\" not found");
        return;
    }

    goal.RecordEvent();
}

private static void LoadGoals()
{
    if (File.Exists(FILENAME))
    {
        using (StreamReader reader = new StreamReader(FILENAME))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');

                switch (parts[0])
                {
                    case "Simple":
                        SimpleGoal simpleGoal = new SimpleGoal
                        {
                            Name = parts[1],
                            Value = int.Parse(parts[2]),
                            IsCompleted = bool.Parse(parts[3]),
                            Score = int.Parse(parts[4])
                        };
                        goals.Add(simpleGoal);
                        break;
                    case "Eternal":
                        EternalGoal eternalGoal = new EternalGoal
                        {
                            Name = parts[1],
                            Value = int.Parse(parts[2]),
                            Score = int.Parse(parts[3])
                        };
                        goals.Add(eternalGoal);
                        break;
                    case "Checklist":
                        ChecklistGoal checklistGoal = new ChecklistGoal
                        {
                            Name = parts[1],
                            Value = int.Parse(parts[2]),
                            TimesCompleted = int.Parse(parts[3]),
                            RequiredTimes = int.Parse(parts[4]),
                            Bonus = int.Parse(parts[5]),
                            Score = int.Parse(parts[6])
                        };
                        goals.Add(checklistGoal);
                        break;
                }
            }
        }
    }
}

private static void SaveGoals()
{
    using (StreamWriter writer = new StreamWriter(FILENAME))
    {
        foreach (Goal goal in goals)
        {
            string type = "";

            if (goal is SimpleGoal)
            {
                type = "Simple";
            }
            else if (goal is EternalGoal)
            {
                type = "Eternal";
            }
            else if (goal is ChecklistGoal)
            {
                type = "Checklist";
            }

            writer.WriteLine($"{type},{goal.Name},{goal.Value},{goal.GetSaveString()},{goal.Score}");
        }
    }
}

}
