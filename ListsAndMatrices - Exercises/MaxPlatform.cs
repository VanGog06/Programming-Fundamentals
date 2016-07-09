/*
Write a program, which reads a rectangular matrix of integers of size of r rows by c columns. Find in the matrix a platform of size 3 x 3 with a maximal sum.

Input
•	The first line holds the number of rows r and the number of columns c.
•	The next r lines hold the elements of the matrix.
•	Constraints: 3 ≤ r, c ≤ 1000.

Output
•	At the first line of the output print the sum.
•	At the next line print the platform itself.
•	If several platforms of equal sum exist, print the one that is located in the lowest row and leftmost column.

Examples
Input	            Output		
4 4                 47
5 6 2 8             6 2 8
3 1 9 5             1 9 5
8 1 6 9             1 6 9
1 5 3 4

5 6                 81
1 2 4 8 9 6         9 9 9  
2 4 1 3 4 2         9 9 9
2 7 9 9 9 7         9 9 9
8 6 9 9 9 6
9 5 9 9 9 9

4 6                 10
1 1 1 1 1 1         1 1 1   
1 1 1 1 1 1         1 1 1
1 1 2 1 1 1         1 1 2
1 1 1 1 1 1
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MaxPlatform
{
    class MaxPlatform
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int rows = int.Parse(input[0]);
            int cols = int.Parse(input[1]);

            List<int> maxMatrix = new List<int>();
            long maxSum = long.MinValue;

            int[][] matrix = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new int[cols];

                string[] matrixArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < matrixArgs.Length; j++)
                {
                    matrix[i][j] = int.Parse(matrixArgs[j]);
                }
            }

            for (int i = 0; i < rows - 2; i++)
            {
                for (int j = 0; j < cols - 2; j++)
                {
                    List<int> listMatrix = new List<int>();
                    listMatrix.Add(matrix[i][j]);
                    listMatrix.Add(matrix[i][j + 1]);
                    listMatrix.Add(matrix[i][j + 2]);
                    listMatrix.Add(matrix[i + 1][j]);
                    listMatrix.Add(matrix[i + 1][j + 1]);
                    listMatrix.Add(matrix[i + 1][j + 2]);
                    listMatrix.Add(matrix[i + 2][j]);
                    listMatrix.Add(matrix[i + 2][j + 1]);
                    listMatrix.Add(matrix[i + 2][j + 2]);

                    if (listMatrix.Sum() > maxSum)
                    {
                        maxSum = listMatrix.Sum();
                        maxMatrix = listMatrix;
                    }
                }
            }

            Console.WriteLine(maxSum);

            for (int i = 0; i < maxMatrix.Count(); i += 3)
            {
                Console.WriteLine(maxMatrix[i] + " " + maxMatrix[i + 1] + " " + maxMatrix[i + 2]);
            }
        }
    }
}
