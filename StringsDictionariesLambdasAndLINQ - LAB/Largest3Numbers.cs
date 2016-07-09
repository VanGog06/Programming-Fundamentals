/*
Read a list of real numbers and print largest 3 of them. If less than 3 numbers exit, print all of them.

Examples
Input	                    Output
10 30 15 20 50 5	        50 30 20
20 30	                    30 20
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Largest3Numbers
{
    class Largest3Numbers
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            Console.WriteLine(string.Join(" ", numbers.OrderByDescending(x => x).Take(3)));
        }
    }
}
