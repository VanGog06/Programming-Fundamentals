/*
Write a program that reverses the words in a given sentence without changing punctuation and spaces
Examples
Input	                                                    Output
C# is not C++, and PHP is not Delphi!	                    Delphi not is PHP, and C++ not is C#!
The quick brown fox jumps over the lazy dog.	            dog lazy the over jumps fox brown quick The.
Pack my box (with five dozen liquor jugs).	                jugs liquor dozen (five with box my Pack).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReverseWordsInSentence
{
    class ReverseWordsInSentenec
    {
        static void Main(string[] args)
        {
            char[] delimiters = { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ', '='};

            string input = Console.ReadLine();

            List<string> reversedWords = input
                .Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToList();

            List<string> splittedDelimiters = input
                .Split(reversedWords.ToArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            for (int i = 0; i < reversedWords.Count; i++)
            {
                Console.Write(reversedWords[i] + splittedDelimiters[i]);
            }

            Console.WriteLine();
        }
    }
}
