using System;

class Program
{
    static void Main(string[] args)
    {
        int elements = 3;
        string[] words = new string [elements];
        words[0] = "Have";
        words[1] = "Some";
        words[2] = "Coffee";
        string WORD = words[2];
        string WORD1 = words[1];
        string WORD0 = words[0];
        Console.WriteLine($"Hello Learning03 World!, I'm learning about so many things including {WORD}, even though I don't take it\n");
        Console.WriteLine($"Hello Learning03 World! do you care to {WORD0} {WORD1} {WORD}?\n");
        Console.WriteLine("This is a test!");        

    }


    
}