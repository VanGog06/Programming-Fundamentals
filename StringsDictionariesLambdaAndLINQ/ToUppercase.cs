/*
A text is given. Write a program that modifies the casing of letters to uppercase at all places in the text surrounded by <upcase> and </upcase> tags. Tags cannot be nested.

Example
Input
Welcome to the <upcase>Software University</upcase>. Learn <upcase>computer programming</upcase> and start a 
<upcase>job</upcase> in a software company.

Output
Welcome to the SOFTWARE UNIVERSITY. Learn COMPUTER PROGRAMMING and start a JOB in a software company.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ToUppercase
{
    class ToUppercase
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            string duplicateWords = words.Replace("<upcase>", "").Replace("</upcase>", "");

            int startIndex = words.IndexOf("<upcase>");
            int nextIndex = startIndex + 1;
            int endIndex = words.IndexOf("</upcase>", nextIndex);
            nextIndex = endIndex + 1;

            while (true)
            {
                if (startIndex == -1 || endIndex == -1)
                {
                    break;
                }

                string upcaseWord = words.Substring(startIndex + "<upcase>".Length,
                                                    endIndex - startIndex - "<upcase>".Length);

                duplicateWords = duplicateWords.Replace(upcaseWord, upcaseWord.ToUpper());

                startIndex = words.IndexOf("<upcase>", nextIndex);
                nextIndex = startIndex + 1;
                endIndex = words.IndexOf("</upcase>", nextIndex);
                nextIndex = endIndex + 1;
            }

            Console.WriteLine(duplicateWords);
        }
    }
}
