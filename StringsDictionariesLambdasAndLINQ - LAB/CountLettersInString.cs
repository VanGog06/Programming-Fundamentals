/*
Read a string and count how many times each character occurs. Print all chars (case insensitive) 
alphabetically with their counts.

Examples
Input	        Output
Alabala	        a -> 4
                b -> 1
                l -> 2

ooooo, kef        -> 1
                , -> 1
                e -> 1
                f -> 1
                k -> 1
                o -> 5

C# Basics	      -> 1
                # -> 1
                a -> 1
                b -> 1
                c -> 2
                i -> 1
                s -> 2
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CountLettersInString
{
    class CountLettersInString
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToLower().ToCharArray();
            Dictionary<char, int> result = new Dictionary<char, int>();

            foreach (var character in input)
            {
                if (result.ContainsKey(character))
                {
                    result[character] += 1;
                }
                else
                {
                    result.Add(character, 1);
                }
            }

            foreach (var entrySet in result.OrderBy(e => e.Key))
            {
                Console.WriteLine("{0} -> {1}", entrySet.Key, entrySet.Value);
            }
        }
    }
}
