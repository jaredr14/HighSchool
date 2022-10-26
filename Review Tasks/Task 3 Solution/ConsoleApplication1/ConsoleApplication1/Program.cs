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
            string sentence;
            char[] letters;
            int vowels = 0;
            bool va = false;
            bool ve = false;
            bool vi = false;
            bool vo = false;
            bool vu = false;

            // get sentence
            Console.WriteLine("Please enter sentence");
            sentence = Console.ReadLine().ToUpper();

            // break into array
            letters = sentence.ToCharArray();

            //check number of vowels
            for (int i = 0; i < sentence.Length; i++)
            {
                if ((letters[i] == 'E') || (letters[i] == 'I') || (letters[i] == 'O') || (letters[i] == 'U') || (letters[i] == 'A'))
                {
                    vowels++;
                }
            }

            Console.WriteLine("The Total number of vowels is " + vowels);

            //display missing vowels
            for (int i = 0; i < sentence.Length; i++)
            {
                if (letters[i] == 'A') va = true;
                if (letters[i] == 'E') ve = true;
                if (letters[i] == 'I') vi = true;
                if (letters[i] == 'O') vo = true;
                if (letters[i] == 'U') vu = true;
            }

            //display based on booleans
            Console.WriteLine("The missing vowels are:");
            if (va == false) Console.WriteLine('A');
            if (ve == false) Console.WriteLine('E');
            if (vi == false) Console.WriteLine('I');
            if (vo == false) Console.WriteLine('O');
            if (vu == false) Console.WriteLine('U');

            Console.ReadKey();

        }
    }
}
