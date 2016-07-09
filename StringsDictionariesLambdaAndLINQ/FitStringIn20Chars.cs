/*
Write a program that reads from the console a string and fits the string in 20 characters as follows:
•	If the string has less than 20 characters, append some ‘*’ until it gets length of exactly 20 characters.
•	If the string length is more than 20 characters, discard all characters after the first 20.
Print the result string at the console.

Examples
Input	                                                Output
Welcome to SoftUni!	                                    Welcome to SoftUni!*
A "regular expression" (abbreviated regex or regexp)    a regular expression
is a sequence of characters that 
forms a search pattern.	
C#	                                                    C#******************
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FitStringIn20Chars
{
    class FitStringIn20Chars
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Length < 20)
            {
                Console.WriteLine(input.PadRight(20, '*'));
            }
            else
            {
                Console.WriteLine(input.Substring(0, 20));
            }
        }
    }
}
