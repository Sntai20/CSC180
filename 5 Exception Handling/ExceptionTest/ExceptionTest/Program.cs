// SOURCE: https://www.microsoft.com
// AUTHOR: Microsoft
// FILENAME: ExceptionTest
// PURPOSE: C# Program to demonstrate exception handling.
// STUDENT: Antonio Santana
// DATE: 1 May 2019
// Changes: 

using System;

namespace ExceptionTest
{
    class MainClass
    {
        static double SafeDivision(double x, double y)
        {
            if (y == 0)
                throw new System.DivideByZeroException();
            return x / y;
        }
        static void Main()
        {
            // Input for test purposes. Change the values to see
            // exception handling behavior.
            double a = 98, b = 0;
            double result = 0;

            try
            {
                result = SafeDivision(a, b);
                Console.WriteLine("{0} divided by {1} = {2}", a, b, result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Attempted divide by zero.");
            }
        }
    }
}
