using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// figure out if a word is a palindrome and display the output to the user 

namespace IntroTask5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLetters;
            string word;
            int yesWord = 0;

            Console.WriteLine("Enter a word that you believe is a palindrome.");
            word = Console.ReadLine();

            char[] Letters = word.ToCharArray();

            numLetters = word.Length;

            for (int x = 0; x <= (numLetters - 1); x++)
            {
                if (Letters[x] == Letters[(numLetters - 1) - x])
                {
                    yesWord++;
                }
            }

            if (yesWord == word.Length)
            {
                Console.WriteLine("This word is a palindrome.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("This word is not a palindrome.");
                Console.ReadKey();
            }
        }
    }
}
