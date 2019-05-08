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
            // Declare two variables as a double data type.
            double m, n;

            // Ask for the user's input and store the value in m.
            Console.WriteLine("Enter the Number : ");
            m = double.Parse(Console.ReadLine());

            // Ask for the user's input and store the value in n.
            Console.WriteLine("Enter the Exponent : ");
            n = double.Parse(Console.ReadLine());

            // Declare value1 as a double and raise to the n power.
            double value1 = Math.Pow(m, n);

            // Return the value to the user.
            Console.WriteLine("Result : {0}", value1);
            Console.ReadLine();
        }
    }
}
/*
Output:
Enter the Number : 
2
Enter the Exponent : 
3
Result : 8
    */
