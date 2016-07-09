/*
Read a list of real numbers and print them in ascending order along with their number of occurrences.

Examples
Input	                    Output
8 2.5 2.5 8 2.5	            2.5 -> 3 times
                            8 -> 2 times

1.5 5 1.5 3	                1.5 -> 2 times
                            3 -> 1 times
                            5 -> 1 times

-2 0.33 0.33 2	            -2 -> 1 times
                            0.33 -> 2 times
                            2 -> 1 times
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            SortedDictionary<double, int> result = new SortedDictionary<double, int>();

            foreach (var number in input)
            {
                if (!result.ContainsKey(number))
                {
                    result.Add(number, 1);
                }
                else
                {
                    result[number] += 1;
                }
            }

            foreach (var pair in result)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
