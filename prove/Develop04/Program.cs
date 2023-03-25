using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome! Select a choice from the menu.");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1 Start Breathing activity.");
        Console.WriteLine("2 Start Reflecting activity.");
        Console.WriteLine("3 Start Listing activity.");

            int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Activity breathingActivity = new BreathingActivity();
            breathingActivity.Run();
            break;
        case 2:
            Activity reflectionActivity = new ReflectionActivity();
            reflectionActivity.Run();
            break;
        case 3:
            Activity listingActivity = new ListingActivity("Listing Activity", "This activity will help you list things that you appreciate or are grateful for.");
            listingActivity.Run();
            break;
        default:
            Console.WriteLine("Invalid choice.");
            break;
    }

    Console.WriteLine("All activities completed. Press any key to exit.");
    Console.ReadKey();
}

    
}

// Base activity class
abstract class Activity
{
    protected string name;
    protected string description;
    protected int duration;

    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void Run()
    {
        DisplayStartingMessage();
        Thread.Sleep(3000);
        RunActivity();
        DisplayFinishingMessage();
        Thread.Sleep(3000);
    }

    protected virtual void DisplayStartingMessage()
    {
        Console.WriteLine($" Welcome to {name}!");
        Console.WriteLine(description);
        Console.Write("Enter duration (in seconds): ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready to start in:");
        for (int i = 3; i >= 1; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
        Console.WriteLine("GO!");
    }

    protected abstract void RunActivity();

    protected virtual void DisplayFinishingMessage()
    {
        Console.WriteLine($"Good job! You have completed {name} for {duration} seconds.");
    }
}

// Breathing activity class
class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    protected override void RunActivity()
    {
        for (int i = 0; i < duration; i += 2)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(2000);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(2000);
        }
    }
}

// Reflection activity class
class ReflectionActivity : Activity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    protected override void RunActivity()
    {
        Random random = new Random();
        for (int i = 0; i < duration; i += 5)
        {
            Console.WriteLine(prompts[random.Next(prompts.Length)]);
            Thread.Sleep(2000);
            foreach (string question in questions)
            {
                Console.WriteLine(question);
                Thread.Sleep(2000);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(1000);
                Console.WriteLine();
            }
        }
    }
}

// Listing activity class
class ListingActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description) : base(name, description) { }

    protected override void RunActivity()
    {
        int duration = GetDurationFromUser();

        Random random = new Random();
        int index = random.Next(prompts.Length);
        string prompt = prompts[index];

        Console.WriteLine(prompt);
        Console.WriteLine("You have " + duration + " seconds to list as many items as you can.");

        int itemsCount = 0;
        while (duration > 0)
        {
            Console.Write(">> ");
            string input = Console.ReadLine();
            if (input != null && input.Trim() != "")
            {
                itemsCount++;
            }
            duration--;
        }

        Console.WriteLine("You listed " + itemsCount + " items.");
    }

    private int GetDurationFromUser()
    {
        Console.Write("Enter duration (in seconds): ");
        int duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready to start in:");
        for (int i = 3; i >= 1; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
        Console.WriteLine("GO!");
        return duration;
    }
}
