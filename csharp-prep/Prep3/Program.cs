using System;

class Program
{
    static void Main(string[] args)
    {
        int numb = 109;
        int g = 110; 
        
            Console.Write($"Welcome\nEnter a magic number between 1 - {g}: ");
            int n = int.Parse(Console.ReadLine());

            while (n != numb)
            {
            Console.Write($"Enter a number between 1 - {g}: ");
            n = int.Parse(Console.ReadLine());
            
            if (n > numb)
            {
                Console.WriteLine("Lower");
            }

            else if (n < numb)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.Write($"Congraluations you guess {numb} right");
            }
            }

        }
    }