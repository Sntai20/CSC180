// SOURCE: https://www.sanfoundry.com
// AUTHOR: Sanfoundry
// FILENAME: CalculatePowerExponent
// PURPOSE: C# Program to Calculate the power exponent value.
// STUDENT: Antonio Santana
// DATE: 1 April 2019
// Changes: 

using System;

namespace CalculatePowerExponent
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double m, n;
            Console.WriteLine("Enter the Number : ");
            m = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Exponent : ");
            n = double.Parse(Console.ReadLine());
            double value1 = Math.Pow(m, n);
            Console.WriteLine("Result : {0}", value1);
            Console.ReadLine();
        }
    }
}

