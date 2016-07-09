/*
Write a program that reads two dates in format dd-MM-yyyy and prints the number of working days between 
these two dates inclusive. Non-working days are:
•	All days that are Saturday or Sunday.
•	All days that are official holidays in Bulgaria:
o	New Year Eve (1 Jan)
o	Liberation Day (3 March)
o	Worker’s day (1 May)
o	Saint George’s Day (6 May)
o	Saints Cyril and Methodius Day (24 May)
o	Unification Day (6 Sept)
o	Independence Day (22 Sept)
o	National Awakening Day (1 Nov)
o	Christmas (24, 25 and 26 Dec)
All days not mentioned above are working and should count.
Examples
Input	            Output
11-04-2016          4
14-04-2016	

11-04-2016          10
22-04-2016	

20-12-2015          7
31-12-2015	
*/

using System;
using System.Globalization;

namespace _01.CountWorkingDays
{
    class CountWorkingDays
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            DateTime startDate = DateTime.ParseExact(firstDate, "d-M-yyyy", CultureInfo.InstalledUICulture);
            DateTime endDate = DateTime.ParseExact(secondDate, "d-M-yyyy", CultureInfo.InstalledUICulture);

            DateTime[] officialHolidays =
            {
                new DateTime(DateTime.Now.Year, 1, 1),
                new DateTime(DateTime.Now.Year, 3, 3),
                new DateTime(DateTime.Now.Year, 5, 1),
                new DateTime(DateTime.Now.Year, 5, 6),
                new DateTime(DateTime.Now.Year, 6, 24),
                new DateTime(DateTime.Now.Year, 9, 6),
                new DateTime(DateTime.Now.Year, 9, 22),
                new DateTime(DateTime.Now.Year, 11, 1),
                new DateTime(DateTime.Now.Year, 12, 24),
                new DateTime(DateTime.Now.Year, 12, 25),
                new DateTime(DateTime.Now.Year, 12, 26),
            };

            int counter = 0;

            for (DateTime i = startDate; i.Date <= endDate.Date; i = i.AddDays(1))
            {
                if (i.DayOfWeek == DayOfWeek.Sunday || i.DayOfWeek == DayOfWeek.Saturday)
                {
                    continue;
                }

                bool isHoliday = false;

                for (int j = 0; j < officialHolidays.Length; j++)
                {
                    if (i.Day == officialHolidays[j].Day && i.Month == officialHolidays[j].Month)
                    {
                        isHoliday = true;
                        break;
                    }
                }

                if (!isHoliday)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
