/*
Write a program that extracts from a text all sentences that contain a particular word.
•	Assume that the sentences are separated from each other by the character "." or "!" or "?".
•	The words are separated one from another by a non-letter character.
•	Not that appearance as substring is different than appearance as word. The sentence “I am a fan of Motorhead” does not contain the word “to”.
•	Print the result sentence text without the separators between the sentences ("." or "!" or "?").

Example
Input
to
Welcome to SoftUni. You will learn programming, algorithms, problems solving and software technologies. You need to allocate for study 20-30 hours weekly. Good luck! I am fan of Motorhead. To be or not to be - that is the question.

Output
Welcome to SoftUni
You need to allocate for study 20-30 hours weekly
To be or not to be - that is the question
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ExtractSentecesByKeyword
{
    class ExtractSentencesByKeyword
    {
        static void Main(string[] args)
        {
            char[] wordsDelimites = { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' '};
            string word = Console.ReadLine();
            string[] sentences = Console.ReadLine().Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var sentence in sentences)
            {
                string[] words = sentence.Split(wordsDelimites, StringSplitOptions.RemoveEmptyEntries);

                foreach (var singleWord in words)
                {
                    if (singleWord.Equals(word))
                    {
                        Console.WriteLine(sentence.Trim());
                        break;
                    }
                }
            }
        }
    }
}
