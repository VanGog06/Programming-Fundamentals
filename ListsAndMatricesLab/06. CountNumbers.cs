/*
Read a list of integers and extract all square numbers from it and print them in descending order. 
A square number is an integer which is the square of any integer. For example, 1, 4, 9, 16 are square numbers.

Examples

Input	                    Output
3 16 4 5 6 8 9 	            16 9 4
12 1 9 4 16 8 25 49 16	    49 25 16 16 9 4 1
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Dictionary<int, int> numbersOccurance = new Dictionary<int, int>();

            foreach (var number in numbers)
            {
                if (!numbersOccurance.ContainsKey(number))
                {
                    numbersOccurance.Add(number, 1);
                }
                else
                {
                    numbersOccurance[number] += 1;
                }
            }



            foreach (var pair in numbersOccurance.OrderBy(e => e.Key))
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
