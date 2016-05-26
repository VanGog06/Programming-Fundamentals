using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LastKNumbersSums
{
    class LastKNumbersSums
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());

            long[] array = new long[size];

            array[0] = 1;

            for (int i = 1; i < size; i++)
            {
                long nextNumber = 0;

                if (count > i)
                {
                    int counter = i - 1;

                    while (counter >= 0)
                    {
                        nextNumber += array[counter];

                        counter--;
                    }

                    array[i] = nextNumber;
                }
                else
                {
                    int counter = 0;

                    while (counter != count)
                    {
                        nextNumber += array[i - counter - 1];

                        counter++;
                    }

                    array[i] = nextNumber;
                }
            }

            Console.WriteLine(String.Join(" ", array));
        }
    }
}
