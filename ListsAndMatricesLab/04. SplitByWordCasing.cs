/*
Read a text, split it into words and distribute them into 3 lists.
	Lower-case words like “programming”, “at” and “databases” – consist of lowercase letters only.
	Upper-case words like “PHP”, “JS” and “SQL” – consist of uppercase letters only.
	Mixed-case words like “C#”, “SoftUni” and “Java” – all others.
Use the following separators between the words: , ; : . ! ( ) " ' \ / [ ] space
Print the 3 lists as shown in the example below.

Examples

Input	                                Output
Learn programming at SoftUni:           Lower-case: programming, at, databases, etc
Java, PHP, JS, HTML 5, CSS, Web,        Mixed-case: Learn, SoftUni, Java, 5, Web, C#
C#, SQL, databases, AJAX, etc.	        Upper-case: PHP, JS, HTML, CSS, SQL, AJAX
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().
                Split(new[] { ' ', ',', ';', ':', '.', '!', '(', ')', '\"', '\'', '/', '\\', '[', ']' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixedCase = new List<string>();

            bool isUpperFound = false;
            bool isLowerFound = false;

            foreach (var item in input)
            {
                char[] charArray = item.ToCharArray();

                foreach (var singleChar in charArray)
                {
                    if ((int)singleChar >= 65 && (int)singleChar <= 90)
                    {
                        isUpperFound = true;
                    }
                    else if ((int)singleChar >= 97 && (int)singleChar <= 122)
                    {
                        isLowerFound = true;
                    }
                    else
                    {
                        isLowerFound = true;
                        isUpperFound = true;
                    }

                    if (isLowerFound && isUpperFound)
                    {
                        break;
                    }
                }

                if (isLowerFound && !isUpperFound)
                {
                    lowerCase.Add(item);
                }
                else if (isUpperFound && !isLowerFound)
                {
                    upperCase.Add(item);
                }
                else
                {
                    mixedCase.Add(item);
                }

                isLowerFound = false;
                isUpperFound = false;
            }

            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCase));
        }
    }
}
