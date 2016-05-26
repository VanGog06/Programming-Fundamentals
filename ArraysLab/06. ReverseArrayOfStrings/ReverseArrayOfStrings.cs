using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RoundingNumbers
{
    class RoundingNumbers
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');

            string[] reversedArray = new string[array.Length];

            for (int i = 0; i <= array.Length / 2; i++)
            {
                reversedArray[i] = array[array.Length - 1 - i];
                reversedArray[array.Length - 1 - i] = array[i];
            }

            Console.WriteLine(String.Join(", ", reversedArray));
        }
    }
}