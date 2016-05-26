using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReverseArrayOfIntegers
{
    class ReverseArrayOfIntegers
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            long[] array = new long[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = long.Parse(Console.ReadLine());
            }

            for (int i = size - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
