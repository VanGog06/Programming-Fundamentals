/*
Write a program that extracts from a given sequence of words all elements that present in it odd 
number of times (case-insensitive).
•	Words are given in a single line, space separated.
•	Print the result elements in lowercase, in their order of appearance.

Examples
Input	                                Output
Java C# PHP PHP JAVA C java	            java, c#, c
3 5 5 hi pi HO Hi 5 ho 3 hi pi	        5, hi
a a A SQL xx a xx a A a XX c	        a, SQL, xx, c
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.OddOccurences
{
    class OddOccurences
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().ToLower().Split().ToList();
            Dictionary<string, int> words = new Dictionary<string, int>();

            foreach (var word in input)
            {
                if (!words.ContainsKey(word))
                {
                    words.Add(word, 1);
                }
                else
                {
                    words[word] += 1;
                }
            }

            List<string> keys = words.Where(e => e.Value % 2 != 0).Select(e => e.Key).ToList();

            Console.WriteLine(string.Join(", ", keys));
        }
    }
}
