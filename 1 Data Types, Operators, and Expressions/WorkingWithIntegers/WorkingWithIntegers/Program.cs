// SOURCE: https://www.microsoft.com
// AUTHOR: Microsoft
// FILENAME: WorkingWithIntegers
// PURPOSE: A simple C# Program to demonstrate integers.
// STUDENT: Antonio Santana
// DATE: 1 May 2019
// Changes: 
using System;

namespace WorkingWithIntegers
{
    class Program
    {
        static void WorkingWithIntegers()
        {
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

        static void Main(string[] args)
        {
            WorkingWithIntegers();
        }
    }
}
