using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name?: ");
        string fname = Console.ReadLine();

        Console.Write("What is your last name?: ");
        string lname = Console.ReadLine();


        Console.WriteLine($"you name is {lname}, {fname} {lname}.");

        Console.WriteLine("Enter you the year you were born: ");
        int yearBorn = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter the month you were born: ");
        string monthName = Console.ReadLine();

        Console.WriteLine("Enter numerical day you were born, example 7: ");
        int dayBorn = Convert.ToInt32(Console.ReadLine());


        int A;
        int B;
        int C;
        int D;
        int E;
        int F;

        A = 2023 - yearBorn;
        B = A;
        C = 19;
        C++;
        D = A + C;

        Console.Write($"Your name is {lname}, {fname} {lname}. You are {B} years old");

        int a = 5;
        while (a <=25)
        {
            a = a + 5;
            Console.WriteLine(a);
        }

        E = D + a;

        F = 2053 + 30;
        Console.WriteLine($"And you will be {E} years old in the {F}");

    }
}