/*
Write a program to generate the following matrix of palindromes of 3 letters with r rows and c columns like at the examples below.
•	Rows define the first and the last letter: row 0  ‘a’, row 1  ‘b’, row 2  ‘c’, …
•	Columns define the middle letter: column 0  ‘a’, column 1  ‘b’, column 2  ‘c’, …

Input
•	The number r and c stay at the first line at the input.
•	Constraints: r and c are integers in the range [1…26]; r+c ≤ 27.

Examples
Input	            Output		
4 6	                aaa aba aca ada aea afa
                    bbb bcb bdb beb bfb bgb
                    ccc cdc cec cfc cgc chc
                    ddd ded dfd dgd dhd did		

3 2	                aaa aba
                    bbb bcb
                    ccc cdc
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main(string[] args)
        {
            string[] matrixArgs = Console.ReadLine().Split();

            int rows = int.Parse(matrixArgs[0]);
            int cols = int.Parse(matrixArgs[1]);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("{0}{1}{0} ", (char)(i + 'a'), (char)(j + i + 'a'));
                }

                Console.WriteLine();
            }
        }
    }
}
