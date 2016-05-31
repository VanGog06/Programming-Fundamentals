/*
Read a list of decimal numbers and sort them in increasing order. Print the output as shown in the examples below.

Examples

Input	                    Output
8 2 7 3	                    2 <= 3 <= 7 <= 8
2 4 -9	                    -9 <= 2 <= 4
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SortNumbers
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            numbers.Sort((e1, e2) => e1.CompareTo(e2));

            Console.WriteLine(string.Join(" <= ", numbers));
        }
    }
}
