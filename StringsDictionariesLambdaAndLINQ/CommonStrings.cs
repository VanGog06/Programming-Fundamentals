/*
You are given two strings, A and B. Find if there is a substring that appears in both A and B.

Examples
Input	Output          Comments
hello   yes             The letter “o” is common between both strings, hence the output is YES. Furthermore the letter “l” 
world		            is common, but you only need 1 common substring

hi
world	no	            Both words do not have common substring

soft
softuni	yes	            Substring “soft” is common between both strings
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.CommonStrings
{
    class CommonStrings
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();

            string shorterString = string.Empty;
            string longerString = string.Empty;

            if (firstString.Length > secondString.Length)
            {
                shorterString = secondString;
                longerString = firstString;
            }
            else
            {
                shorterString = firstString;
                longerString = secondString;
            }

            int number = 1;
            bool isFound = false;

            while (number <= shorterString.Length)
            {
                for (int i = 0; i <= shorterString.Length - 1; i += 1)
                {
                    string currentString = new string(shorterString.Skip(i).Take(number).ToArray());
                    if (longerString.IndexOf(currentString) != -1)
                    {
                        Console.WriteLine("yes");
                        isFound = true;
                        break;
                    }

                    if (isFound)
                    {
                        break;
                    }
                }

                if (isFound)
                {
                    break;
                }

                number++;
            }

            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
