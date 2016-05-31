/*
Write a program to read a matrix of words (space separated) and rotate it on the right as shown in the examples.

Examples

Input	                Output
3
4
A B C D                 I E A
E F G H                 J F B
I J K L                 K G C
                        L H D

3
3
Hi PHP Java             HTML C# Hi
C# SQL JSON             CSS SQL PHP
HTML CSS JS	            JS JSON Java
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RotateAMatrix
{
    class RotateAMatrix
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            string[,] matrix = new string[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                for (int j = 0; j < input.Length; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            for (int i = 0; i < cols; i++)
            {
                for (int j = rows - 1; j >= 0; j--)
                {
                    Console.Write(matrix[j, i] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
