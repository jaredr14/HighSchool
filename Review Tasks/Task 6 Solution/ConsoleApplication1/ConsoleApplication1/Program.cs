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

            //variables
            string[] classnames = { "Nathan", "Jasnit", "Thaxter", "DJ Raven (aka Mr. Tamil)", "Gagan", "Arthur", "Anseigh", "Nicole" };
            string[] sortednames = { "", "", "", "", "", "", "", "" };
            Random box = new Random();
            int num;
            int ctr = 0;

            //idea is that we get a random number, and place that element in new array and replace it in old array with "Tirf"

            while (ctr < classnames.Length)
            {
                num = box.Next(0, classnames.Length);
                if (classnames[num] != "Tirf")
                {
                    sortednames[ctr] = classnames[num];
                    classnames[num] = "Tirf";
                    ctr++;
                }
            }

            //diaplay new sorted array
            foreach (string person in sortednames)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press Any Key To Exit");

            Console.ReadKey();

        }
    }
}
