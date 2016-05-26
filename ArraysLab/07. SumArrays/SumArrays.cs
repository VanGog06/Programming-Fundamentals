using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumArrays
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int length = Math.Max(firstArray.Length, secondArray.Length);
            int[] newArray = new int[length];

            int index = 0;

            if (firstArray.Length > secondArray.Length)
            {
                Array.Copy(secondArray, newArray, secondArray.Length);

                for (int i = secondArray.Length; i < firstArray.Length; i++)
                {
                    if (index >= secondArray.Length)
                    {
                        index = 0;
                    }

                    newArray[i] = secondArray[index];
                    index++;
                }

                PrintArray(firstArray, newArray);
            }
            else if (secondArray.Length > firstArray.Length)
            {
                Array.Copy(firstArray, newArray, firstArray.Length);

                for (int i = firstArray.Length; i < secondArray.Length; i++)
                {
                    if (index >= firstArray.Length)
                    {
                        index = 0;
                    }

                    newArray[i] = firstArray[index];
                    index++;
                }

                PrintArray(newArray, secondArray);
            }
            else
            {
                PrintArray(firstArray, secondArray);
            }
            
        }

        static void PrintArray(int[] firstArray, int[] secondArray)
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write("{0} ", firstArray[i] + secondArray[i]);
            }

            Console.WriteLine();
        }
    }
}
