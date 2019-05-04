// SOURCE: https://www.sanfoundry.com
// AUTHOR: Sanfoundry
// FILENAME: CalculateAcceleration
// PURPOSE: C# Program to Calculate Acceleration.
// STUDENT: Antonio Santana
// DATE: 19 April 2019

using System;

namespace CalculateAcceleration
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int v, t, acc;
            Console.WriteLine("Enter the Velocity : ");
            v = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Time : ");
            t = int.Parse(Console.ReadLine());
            acc = v / t;
            Console.WriteLine("Acceleration : {0}", acc);
        }
    }
}



