/*
Read a list of integers, remove all negative numbers from it and print the remaining elements in reversed order. 
In case of no elements left in the list, print “empty”.

Examples

Input	                    Output
10 -5 7 9 -33 50	        50 9 7 10
7 -2 -10 1	                1 7
-1 -2 -3	                empty
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RemoveNegativesAndReverse
{
    class RemoveNegativesAndReverse
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            bool isPrinted = false;

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (numbers[i] > 0)
                {
                    Console.Write(numbers[i] + " ");
                    isPrinted = true;
                }
            }

            if (!isPrinted)
            {
                Console.WriteLine("empty");
            }
        }
    }
}
