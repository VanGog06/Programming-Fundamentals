/*
You are given a list of words in one line. Randomize their order and print each word at a separate line.
Examples
Input	                            Output	                        Comments
Welcome to SoftUni and have         learning                        The order of the words in the output will be different 
fun learning programming	        Welcome                         after each program execution.
                                    SoftUni
                                    and
                                    fun
                                    programming
                                    have
                                    to	
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RandomizeWords
{
    class RandomizeWords
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();

            Random random = new Random();
            int length = words.Count;

            for (int i = 0; i < length; i++)
            {
                int rnd = random.Next(0, words.Count);

                Console.WriteLine(words[rnd]);
                words.RemoveAt(rnd);
            }
        }
    }
}
