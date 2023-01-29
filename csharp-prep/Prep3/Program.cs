using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();

        int magicNumber = rnd.Next(1, 101);

        int g = -1;
        
        //int numb = 109;
        //int g = 110; 
        
            //Console.Write($"Welcome\nEnter a magic number between 1 - {g}: ");
            //int n = int.Parse(Console.ReadLine());

        while (g != magicNumber)
            //while (n != numb)
        {   
            //Console.WriteLine(magicNumber);
            Console.Write("Guess a number: ");
            g = int.Parse(Console.ReadLine());
            
            if (magicNumber < g)
            {
                Console.WriteLine("Lower");
            }

            else if (magicNumber > g)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.Write($"Congraluations you guessed right. The magic Number is: {magicNumber} ");
            }
            }

        }
    }