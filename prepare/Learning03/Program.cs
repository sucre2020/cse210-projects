using System;

class Program
{
    static void Main(string[] args)
    {

       // Person Me = new Person();
       // Me.firstName = "Efita";
       // Me.age = "Ask Google";
       // Me.lastName = "Effiom";
        //Me.country = "Celestial Kingdom";


        //Console.WriteLine(Me.firstName);
        //Console.WriteLine(Me.lastName);
        //Console.WriteLine(Me.age);
        //Console.WriteLine(Me.country);

        //int elements = 3;
        //string[] words = new string [elements];
        //words[0] = "Have";
        //words[1] = "Some";
        //words[2] = "Coffee";
        //string WORD = words[2];
        //string WORD1 = words[1];
        //string WORD0 = words[0];
        //Console.WriteLine($"Hello Learning03 World!, I'm learning about so many things including {WORD}, even though I don't take it\n");
        //Console.WriteLine($"Hello Learning03 World! do you care to {WORD0} {WORD1} {WORD}?\n");
       // Console.WriteLine("This is a test!");      

    //}

   // class Person
   // {
       // public string firstName;
       // public string lastName;
       // public string age;
       // public string country;
       // private string politicalAffiliation;
    //}

        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}