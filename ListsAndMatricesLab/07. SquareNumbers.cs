/*
Read a list of integers in range [0…1000] and print them in ascending order along with their number of occurrences.

Examples

Input	                    Output
8 2 2 8 2 2 3 7	            2 -> 4
                            3 -> 1
                            7 -> 1
                            8 -> 2

10 8 8 10 10	            8 -> 2
                            10 -> 3
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(long.Parse).ToList();

            numbers.Sort((e1, e2) => e2.CompareTo(e1));

            foreach (var number in numbers)
            {
                if ((Math.Sqrt(number)) % 1 == 0)
                {
                    Console.Write(number + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
