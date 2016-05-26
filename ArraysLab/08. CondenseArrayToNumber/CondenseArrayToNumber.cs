using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CondenseArrayToNumber
{
    class CondenseArrayToNumber
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int length = array.Length - 1;

            while (length >= 1)
            {
                int[] newArray = new int[length];

                for (int i = 0; i < newArray.Length; i++)
                {
                    newArray[i] = array[i] + array[i + 1];
                }

                array = new int[length];
                Array.Copy(newArray, array, length);

                length--;
            }

            Console.WriteLine(array[0]);
        }
    }
}
