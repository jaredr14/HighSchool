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
            
            int chose;
            int lives = 10;
            Random num = new Random();
            int rad = num.Next(0, 101);

            Console.WriteLine("A NUMBER WAS CHOSSEN BETWEEN 1 AND 100");
            Console.WriteLine("Please try to guess the number");
            chose = int.Parse(Console.ReadLine());

            while (chose != rad)
            {
                if (chose > rad)
                {
                    lives = lives - 1;
                    Console.WriteLine("Your guess was too high");
                    Console.WriteLine("You have " + lives + " Left");
                    Console.WriteLine("Try again");
                    chose = int.Parse(Console.ReadLine());
                }

                if (chose < rad)
                {
                    lives = lives - 1;
                    Console.WriteLine("Your guess was too low");
                    Console.WriteLine("You have " + lives + " Left");
                    Console.WriteLine("Try again");
                    chose = int.Parse(Console.ReadLine());
                }

                if (lives == 0)
                {
                    Console.WriteLine("Sorry you've ran out of lives");
                    Console.WriteLine("The number was " + rad);
                    Console.WriteLine("Please Try Again!");
                    Environment.Exit(0);
                }

            }

            
        }
    }
}
