/*
Read a text and several forbidden words.Replace all forbidden words with stars(e.g.beer -> ****). 
Use "substring" matching(match part of word), case-sensitive.Use the same number of stars like the word length.

Examples
Input 
Learn how to earn money or read the HOWto e-learning.
beer how programming PHP MySQL earn bitcoins

Output  
L**** *** to **** money or read the HOWto e-l****ing
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsDictionariesLambdasAndLINQ___LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] forbiddenWords = Console.ReadLine().Split().ToArray();

            foreach (var forbiddenWord in forbiddenWords)
            {
                input = input.Replace(forbiddenWord, new string('*', forbiddenWord.Length));
            }

            Console.WriteLine(input);
        }
    }
}
