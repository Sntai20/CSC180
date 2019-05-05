// SOURCE: https://www.sanfoundry.com
// AUTHOR: Sanfoundry
// FILENAME: CalculateAcceleration
// PURPOSE: C# Program to Calculate Acceleration.
// STUDENT: Antonio Santana
// DATE: 19 April 2019
// Changes: Data types to a double and added expected output.

using System;

namespace CalculateAcceleration
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Declares int data types.
            double v, t, acc;

            // Request and stores user input to v as in int.
            Console.WriteLine("Enter the Velocity : ");
            v = double.Parse(Console.ReadLine());

            // Request and stores user input to t as an int.
            Console.WriteLine("Enter the Time : ");
            t = double.Parse(Console.ReadLine());

            // Uses a divide operator to calculate acceleration.
            acc = v / t;
            Console.WriteLine("Acceleration : {0}", acc);
        }
    }
}
/*
         Output:
            Enter the Velocity : 
            100
            Enter the Time : 
            60
            Acceleration : 1.66666666666667         
      */


