using System;
using System.Collections.Generic;

namespace ExerciseTracker
{
    public class ExerciseTracker
    {
        public static void Main()
        {
            List<Activity> activities = new List<Activity>();

                   // Prompt user to add an activity
        //Console.WriteLine("Add an activity:");
        Console.Write("Enter year-month-day for Activity\n Date (yyyy-mm-dd): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        Console.Write("Length (minutes): ");
        int length = int.Parse(Console.ReadLine());
        Console.WriteLine("Choose an activity type:");
        Console.WriteLine("1. Running");
        Console.WriteLine("2. Stationary Bicycle");
        Console.WriteLine("3. Lap Swimming");
        int activityType = int.Parse(Console.ReadLine());

        switch (activityType)
        {
            case 1:
                Console.Write("Distance (miles): ");
                double distance = double.Parse(Console.ReadLine());
                activities.Add(new Running(date, length, distance));
                break;
            case 2:
                Console.Write("Speed (mph): ");
                double speed = double.Parse(Console.ReadLine());
                activities.Add(new StationaryBicycle(date, length, speed));
                break;
            case 3:
                Console.Write("Laps: ");
                int laps = int.Parse(Console.ReadLine());
                activities.Add(new LapSwimming(date, length, laps));
                break;
            default:
                Console.WriteLine("Invalid activity type.");
                break;
        }

        // Display summary of all activities
        Console.WriteLine("\nActivity summary:");
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
}
