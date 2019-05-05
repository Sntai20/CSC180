// SOURCE: https://www.microsoft.com
// AUTHOR: Microsoft
// FILENAME: ProgramGuide
// PURPOSE: A simple C# Program to demonstrate a class and construct.
// STUDENT: Antonio Santana
// DATE: 1 May 2019
// Changes: 
using System;

namespace ProgramGuide
{
    // Another class definition that contains Main, the program entry point.
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of type CustomClass.
            CustomClass custClass = new CustomClass();

            // Set the value of the public property.
            custClass.Number = 27;

            // Call the public method.
            int result = custClass.Multiply(4);
            Console.WriteLine($"The result is {result}.");
        }

        // Class definition.
        public class CustomClass
        {
            // Class members.
            //
            // Property.
            public int Number { get; set; }

            // Method.
            public int Multiply(int num)
            {
                return num * Number;
            }

            // Instance Constructor.
            public CustomClass()
            {
                Number = 0;
            }
        }
        // The example displays the following output:
        //      The result is 108.
    }
}



