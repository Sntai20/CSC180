// SOURCE: https://www.microsoft.com
// AUTHOR: Microsoft
// FILENAME: WorkingWithIntegers
// PURPOSE: A simple C# Program to demonstrate integers.
// STUDENT: Antonio Santana
// DATE: 1 April 2019
// Changes: 
using System;

namespace WorkingWithIntegers
{
    class Program
    {
        // Access modifier public means the type members are accessible.
        public static void Main(string[] args)
        {
            // Calls a WorkingWithIntegers function.
            WorkingWithIntegers();
        }

        // Function declares and initailizes a,b,c as integers. 
        private static void WorkingWithIntegers()
        {
            // Arithmetic operators perform calculations on variables.
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);
            c = a - b;
            Console.WriteLine(c);
            c = a * b;
            Console.WriteLine(c);
            c = a / b;
            Console.WriteLine(c);
        }
    }
}
