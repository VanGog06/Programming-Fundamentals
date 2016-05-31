/*
Write a program to append several lists of numbers.
	Lists are separated by ‘|’.
	Values are separated by spaces (‘ ’, one or several)
	Order the lists from the last to the first, and their values from left to right.

Examples

Input	                        Output
1 2 3 |4 5 6 |  7  8	        7 8 4 5 6 1 2 3
7 | 4  5|1 0| 2 5 |3	        3 2 5 1 0 4 5 7
1| 4 5 6 7  |  8 9	            8 9 4 5 6 7 1
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.AppendLists
{
    class AppendLists
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = input.Count - 1; i >= 0; i--)
            {
                string[] splitted = Regex.Split(input[i].Trim(), @"\s+");
                Console.Write(string.Join(" ", splitted) + " ");
            }

            Console.WriteLine();
        }
    }
}
