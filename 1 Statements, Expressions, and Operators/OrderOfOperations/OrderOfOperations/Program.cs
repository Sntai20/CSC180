// SOURCE: https://www.microsoft.com
// AUTHOR: Microsoft
// FILENAME: OrderOfOperations
// PURPOSE: A simple C# Program to demonstrate Order Of Operations.
// STUDENT: Antonio Santana
// DATE: 1 May 2019
// Changes: 
using System;

namespace OrderOfOperations
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            WorkingWithIntegers();

            OrderPrecedence();

        }

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

        static void OrderPrecedence()
        {
            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine(d);

            d = (a + b) * c;
            Console.WriteLine(d);

            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);

            int e = 7;
            int f = 4;
            int g = 3;
            int h = (e + f) / g;
            Console.WriteLine(h);
        }
    }
}
