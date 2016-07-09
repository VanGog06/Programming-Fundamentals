/*
Write a program that finds the difference between the sums of the square matrix diagonals (absolute value).
 
Input
•	The first line holds a number n – the size of matrix.
•	The next n lines hold the values for every row – n numbers separated by a space.

Examples
Input	            Output	                Comments
3                   15                      Primary diagonal: sum = 11 + 5 + (-12) = 4
11 2 4                                      Secondary diagonal: sum = 4 + 5 + 10 = 19
4 5 6                                       Difference: |4 - 19| = 15
10 8 -12		
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DiagonalDifference
{
    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;

            for (int i = 0; i < size; i++)
            {
                string[] rowArgs = Console.ReadLine().Split();

                primaryDiagonal += int.Parse(rowArgs[i]);
                secondaryDiagonal += int.Parse(rowArgs[rowArgs.Length - i - 1]);
            }

            Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));
        }
    }
}
