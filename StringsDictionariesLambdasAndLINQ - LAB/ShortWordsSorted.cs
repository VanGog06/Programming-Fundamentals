/*
Read a text, extract its words, find all short words (less than 5 characters) and print them alphabetically, in lowercase.
•	Use the following separators: . , : ; ( ) [ ] " ' \ / ! ? (space).
•	Use case-insensitive matching.
•	Remove duplicated words.

Examples
Input	                                                    Output
In SoftUni you can study Java, C#, PHP and JavaScript.      2-3, and, c#, can, go, in, java, php, you
JAVA and c# developers graduate in 2-3 years. Go in!	
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ShortWordsSorted
{
    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            char[] delimiters = { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' };

            List<string> words = Console.ReadLine()
                .ToLower()
                .Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                .Where(e => e.Length < 5)
                .OrderBy(e => e).Distinct()
                .ToList();

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
