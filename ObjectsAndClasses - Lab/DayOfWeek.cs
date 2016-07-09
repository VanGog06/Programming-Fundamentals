/*
You are given a date in format day-month-year. Calculate and print the day of week in English.
Examples
Input	        Output
18-04-2016	    Monday
27-11-1996	    Wednesday
*/

using System;
using System.Globalization;

namespace _01.DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            string dateString = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateString, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
