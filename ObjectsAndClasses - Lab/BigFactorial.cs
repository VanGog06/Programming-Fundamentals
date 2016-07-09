/*
Calculate and print n! (n factorial) for very big integer n (e.g. 1000).

Examples
Input	        Output
5	            120
50	            3041409320171337804361260816606476884437764156896051200000000000
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace _03.BigFactorial
{
    class BigFactorial
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            BigInteger fact = 1;

            for (int i = 2; i <= number; i++)
            {
                fact *= i;
            }

            Console.WriteLine(fact);
        }
    }
}
