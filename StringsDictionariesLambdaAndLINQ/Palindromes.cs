/*
Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe and prints them on the console on a single line, separated by comma and space. Use spaces, commas, dots, question marks and exclamation marks as word delimiters. Print only unique palindromes, sorted lexicographically.

Examples
Input	                                        Output
Hi,exe? ABBA! Hog fully a string. Bob	        a, ABBA, exe
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            char[] delimiters = { ' ', ',', '.', '?', '!' };
            List<string> words = Console.ReadLine()
                .Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .ToList();

            List<string> palindromes = new List<string>();

            foreach (var word in words)
            {
                if (word.Equals(new string(word.ToCharArray().Reverse().ToArray())))
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", palindromes.OrderBy(e => e)));
        }
    }
}
