/*
Read a list of integers and find the longest sequence of equal elements. If several exist, print the leftmost.

Examples
Input	                    Output
3 4 4 5 5 5 2 2	            5 5 5
7 7 4 4 5 5 3 3         	7 7
1 2 3 3	                    3 3
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine().Split().Select(long.Parse).ToList();
            bool isFound = false;

            long maxNumber = long.MinValue;
            int counter = 1;
            long maxCounter = 0;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                    isFound = true;

                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        maxNumber = numbers[i];
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            for (int i = 0; i < maxCounter; i++)
            {
                Console.Write(maxNumber + " ");
            }

            if (numbers.Count == 1 || !isFound)
            {
                Console.WriteLine(numbers[0]);
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
