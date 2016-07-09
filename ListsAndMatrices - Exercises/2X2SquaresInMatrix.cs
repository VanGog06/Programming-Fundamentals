/*
Find the count of 2 x 2 squares of equal chars in a matrix.
•	The matrix size is given at the first row (rows and columns).
•	Matrix characters come at the next rows lines (space separated).

Examples
Input	            Output	               
3 4                 2
A B B D
E B B B
I J B B

2 2                 0
a b
c d
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._2X2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] matrixArgs = Console.ReadLine().Split();

            int rows = int.Parse(matrixArgs[0]);
            int cols = int.Parse(matrixArgs[1]);

            int counter = 0;

            string[][] matrix = new string[rows][];

            for (int i = 0; i < rows; i++)
            {
                string[] line = Console.ReadLine().Split();
                matrix[i] = new string[line.Length];

                for (int j = 0; j < line.Length; j++)
                {
                    matrix[i][j] = line[j];
                }
            }

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    if ((matrix[i][j] == matrix[i][j + 1]) &&
                        (matrix[i + 1][j] == matrix[i + 1][j + 1]) &&
                        (matrix[i][j] == matrix[i + 1][j]))
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
