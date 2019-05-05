using System;

namespace ConvertDaysToWeeks
{
    class MainClass
    {
        public static void Main()
        {
            // Declare integers
            int ndays, year, week, days, DAYSINWEEK = 7;

            // Ask for user input and store in ndays.
            Console.WriteLine("Enter the number of days");
            ndays = int.Parse(Console.ReadLine());

            // Calculate number of days in years, weeks, and days.
            year = ndays / 365;
            week = (ndays % 365) / DAYSINWEEK;
            days = (ndays % 365) % DAYSINWEEK;
            Console.WriteLine("{0} is equivalent to {1}years, {2}weeks and {3}days",
                               ndays, year, week, days);
            //TODO create while loop
            //TODO create exit
            //Console.ReadLine();
        }
    }
}
