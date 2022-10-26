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

            //creating variables to get user input

            int firstnum;
            int secondnum;
            int total=0;

            //get user input
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please Enter your first number");
            Console.ForegroundColor = ConsoleColor.White;
            firstnum = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please Enter your second number");
            Console.ForegroundColor = ConsoleColor.White;
            secondnum = int.Parse(Console.ReadLine());

            //sort first and second number so that firstnum is the lowest.  Ex... what if they enter 9 then 4.
            if (secondnum < firstnum)
            {
                int temp = firstnum;  //give firstnum to temporary place holder
                firstnum = secondnum; //replace firstnum with secondnum
                secondnum = temp; //put the temp (original firstnum) into secondnum
            }

            //find the sum of all numbers divisible by 3 or 7 from firstnum to secondnum
            for (int i = firstnum; i <= secondnum; i++)
            {
                if ((i%3==0)||(i%7==0))
                {
                    total = total + i;
                }
            }

            // Display total
            Console.Write("The numbers divisible by 3 or 7 from " + firstnum + " to " + secondnum + " add to ");Console.ForegroundColor = ConsoleColor.Yellow;Console.Write(total.ToString());
            Console.ReadKey();
        }
    }
}
