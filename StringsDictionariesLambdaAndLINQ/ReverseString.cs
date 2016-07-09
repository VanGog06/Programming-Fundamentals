/*
Write a program that reads a string from the console, reverses its letters and prints the result back at the console.

Examples
Input	        Output 
sample	        elpmas
24tvcoi92	    29iocvt42
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Array.Reverse(input);
            Console.WriteLine(string.Join("", input));
        }
    }
}
