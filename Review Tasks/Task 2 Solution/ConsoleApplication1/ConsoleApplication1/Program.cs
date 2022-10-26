using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //task 2 - guessing game

            int count = 0;
            Random box = new Random();
            int randomnumber = box.Next(1,101); //gets number between 1 and 100.
            int guess;
                
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please guess a number");
            Console.ForegroundColor = ConsoleColor.White;
            guess = int.Parse(Console.ReadLine());

            while (count < 10)
            {
                count++;
                if (count == 9)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Last guess!  Take your shot"); 
                    Console.ForegroundColor = ConsoleColor.White;
                    guess = int.Parse(Console.ReadLine());
                    if (guess == randomnumber)
                    {
                        Console.WriteLine("You got it!");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    else
                        break;

                }

                else if (guess < randomnumber)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Guess is too low. Please enter another number");
                    Console.ForegroundColor = ConsoleColor.White;
                    guess = int.Parse(Console.ReadLine());
                }
                else if (guess > randomnumber)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Guess is too high.  Please enter another number");
                    Console.ForegroundColor = ConsoleColor.White;
                    guess = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("You got it!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

            }

            Console.WriteLine("You have exceeded your try count");
            Console.ReadKey();
        }
    }
}
