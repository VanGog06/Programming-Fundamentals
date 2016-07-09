/*
3.	Print a Receipt
Read a sequence of numbers (space separated numbers on a single line) and print a receipt of width 24 chars, 
formatted like at the examples below. Each number should be printed on a separate line with exactly 2 digits 
after the decimal point, eventually rounded.

Examples
Input	                            Output
12.5 7 0.50234	                /----------------------\
                                |                12.50 |
                                |                 7.00 |
                                |                 0.50 |
                                |----------------------|
                                | Total:         20.00 |
                                \----------------------/

460 000230 450.6666666          /----------------------\
                                |               460.00 |
                                |               230.00 |
                                |               450.67 |
                                |----------------------|
                                | Total:       1140.67 |
                                \----------------------/
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PrintAReceipt
{
    class PrintAReceipt
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine().Split().Select(decimal.Parse).ToList();

            Console.WriteLine(@"/----------------------\");

            foreach (var number in numbers)
            {
                Console.WriteLine("|{0,21:F2} |", number);
            }

            Console.WriteLine("|----------------------|");
            Console.WriteLine("| Total:{0,14:F2} |", numbers.Sum());

            Console.WriteLine(@"\----------------------/");
        }
    }
}
