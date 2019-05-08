// SOURCE: https://www.microsoft.com
// AUTHOR: Microsoft
// FILENAME: foreachArray
// PURPOSE: A simple C# Program to demonstrate iteration logic with an Array.
// STUDENT: Antonio Santana
// DATE: 1 May 2019
// Changes: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreachArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array named numbers of type int.
            int[] numbers = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };

            // Iterate through each number and print to screen.
            foreach (int i in numbers)
            {
                System.Console.Write("{0} ", i);
            }
        }
    }
}
/*
Output:
4 5 6 1 2 3 -2 -1 0
    */
