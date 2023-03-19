using System;

class Program
{
    static void Main(string[] args)
    {

        Person Me = new Person();
        Me.firstName = "Efita";
        Me.age = "Ask Google";
        Me.lastName = "Effiom";
        Me.country = "Celestial Kingdom";


        Console.WriteLine(Me.firstName);
        Console.WriteLine(Me.lastName);
        Console.WriteLine(Me.age);
        Console.WriteLine(Me.country);

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

    }

    class Person
    {
        public string firstName;
        public string lastName;
        public string age;
        public string country;
        private string politicalAffiliation;
    }



    
}