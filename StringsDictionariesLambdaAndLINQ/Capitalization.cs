/*
Write a program which takes input string and capitalizes the first character of each word and does not affect the others.

Examples
Input	                Output
jon skeet	            Jon Skeet
old mcdonald	        Old Mcdonald
miles o'Brien	        Miles O'Brien
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Capitalization
{
    class Capitalization
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();

            foreach (var word in words)
            {
                char[] charWord = word.ToCharArray();
                charWord[0] = char.ToUpper(charWord[0]);
                Console.Write(string.Join("", charWord) + " ");
            }

            Console.WriteLine();
        }
    }
}
