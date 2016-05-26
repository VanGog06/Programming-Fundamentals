using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int chosenDay = int.Parse(Console.ReadLine());

            if (chosenDay >= 1 && chosenDay <= 7)
            {
                Console.WriteLine(daysOfWeek[chosenDay - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day");
            }
        }
    }
}
