/*
Given a string of lowercase letters, determine the index of the character whose removal will make the string a palindrome. 
If the string is already a palindrome, then print -1. There will always be a valid solution.

Examples
Input	    Output	                Comments
aaab	    3	                    If we remove letter “b” at index 3 we will get a palindrome “aaa”
baa	        0	                    Remove “b” at index 0 to get a palindrome
aaa	        -1	                    “aaa” is already a palidrome
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PalindromeIndex
{
    class PalindromeIndex
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Equals(new string(input.ToCharArray().Reverse().ToArray())))
            {
                Console.WriteLine(-1);
            }
            else
            {
                char[] charInput = input.ToCharArray();

                for (int i = 0; i < charInput.Length; i++)
                {
                    char[] newCharInput = new string(charInput
                                                    .Where((e, index) => index != i)
                                                    .ToArray())
                                          .ToCharArray();

                    if (string.Join("", newCharInput).Equals(new string(newCharInput.Reverse().ToArray())))
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
        }
    }
}
