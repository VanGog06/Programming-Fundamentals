using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum__Min__Max__First__Last__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[] array = new long[n];

            long sum = 0;
            long min = long.MaxValue;
            long max = long.MinValue;

            for (int i = 0; i < n; i++)
            {
                array[i] = long.Parse(Console.ReadLine());
                sum += array[i];

                if (min > array[i])
                {
                    min = array[i];
                }

                if (max < array[i])
                {
                    max = array[i];
                }
            }

            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Min = " + min);
            Console.WriteLine("Max = " + max);
            Console.WriteLine("First = " + array[0]);
            Console.WriteLine("Last = " + array[array.Length - 1]);
            Console.WriteLine("Average = " + (double)sum / n);
        }
    }
}
