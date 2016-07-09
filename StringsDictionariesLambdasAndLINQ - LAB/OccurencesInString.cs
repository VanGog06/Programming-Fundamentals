/*
Read a text and a word and count how many times the word occurs in the text as substring. The input holds 
two text lines: the text and the substring (word). The output consists of an integer number.

Examples 
Input	            Output		
Alabala             2
la		
	
aaaabaaa            5
aa		

Hello, hello        2
he	
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.OccurencesInString
{
    class OccurencesInString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string searchFor = Console.ReadLine().ToLower();

            int counter = 0;
            int index = -1;

            while (true)
            {
                index = input.IndexOf(searchFor, index + 1);

                if (index == -1)
                {
                    break;
                }

                counter++;
            }

            Console.WriteLine(counter);
        }
    }
}
