﻿// SOURCE: https://www.microsoft.com
// AUTHOR: Microsoft
// FILENAME: DaysOfTheWeek
// PURPOSE: A simple C# Program to demonstrate iteration logic.
// STUDENT: Antonio Santana
// DATE: 1 May 2019
// Changes: 

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfTheWeek
{
    class Program
    {
        static void Main()
        {
            // Create a "days" local variable.
            DaysOfTheWeek days = new DaysOfTheWeek();

            // Iterate each day in days and print to string.
            foreach (string day in days)
            {
                Console.Write(day + " ");
            }
            Console.ReadKey();
        }

        // DayOfTheWeek class
        public class DaysOfTheWeek : IEnumerable
        {
            // Create a string array of days.
            private string[] days = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            public IEnumerator GetEnumerator()
            {
                for (int index = 0; index < days.Length; index++)
                {
                    // Yield each day of the week.
                    yield return days[index];
                }
            }
        }
    }
}
/*
Output:
Sun Mon Tue Wed Thu Fri Sat
    */
