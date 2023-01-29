using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        //List<string> words = new List<string>();
        //words.Add("Father");
        //words.Add("Mother");
        //words.Add("Children");
        //words.Add("Family of four");
        //words.Add("Maybe a family of 8");
        //Console.WriteLine(words.Count);
        //Console.WriteLine("");

        //foreach (string word in words)
        //{
          //  Console.WriteLine(word);
        //}
        List<int> numbers = new List<int>();
        //for (int i = 0; i < words.Count; i++)
        //Console.WriteLine(words[i]);

        int usernumber = -1;
        while (usernumber != 0)

        {
          Console.Write("Please enter a positive number or (0 to quit): ");

          string answer = Console.ReadLine();
          usernumber = int.Parse(answer);

          if (usernumber != 0)

          {
            numbers.Add(usernumber);
          }
        }

        int sum = 0;
        foreach (int number in numbers)

        {
          sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");


        float average = ((float)sum) / numbers.Count;
        string formattedAverage = average.ToString("0.00");
        Console.WriteLine($"The average is: {formattedAverage}");



        int max = numbers[0];

        foreach (int number in numbers)

        {
          if (number > max)
          {
            max = number;
          }
        }
        Console.WriteLine($"The max is: {max}");  
    }
}