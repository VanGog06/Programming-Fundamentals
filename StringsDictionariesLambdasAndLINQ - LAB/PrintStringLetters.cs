/*
Read a string and print its letters as in the examples below.

Examples
Input	            Output
SoftUni	            str[0] -> 'S'
                    str[1] -> 'o'
                    str[2] -> 'f'
                    str[3] -> 't'
                    str[4] -> 'U'
                    str[5] -> 'n'
                    str[6] -> 'i'
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PrintStringLetters
{
    class PrintStringLetters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine("str[{0}] -> '{1}'", i, input[i]);
            }
        }
    }
}
