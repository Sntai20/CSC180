// SOURCE: https://www.microsoft.com
// AUTHOR: Microsoft
// FILENAME: foreachMultiArray
// PURPOSE: A simple C# Program to demonstrate iteration logic with 2D array.
// STUDENT: Antonio Santana
// DATE: 1 May 2019
// Changes: Implemented the short form of creating a 2D array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreachMultiArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create three rows and two columns. 
            int[,] numbers2D = new int[3, 2] { { 9, 99 }, { 3, 33 }, { 5, 55 } };

            // Implemented the short form:
            int[,] numbers2D2 = { { 8, 88 }, { 2, 22 }, { 4, 44 } };

            // Iterate through each element in both arrays and print values.
            foreach (int i in numbers2D)
            {
                System.Console.Write("{0} ", i);
            }

            System.Console.WriteLine("Iterate through each element in numbers2D2 and print values.");
            // Iterate through each element in numbers2D2 and print values.
            foreach (int i in numbers2D2)
            {
                System.Console.Write("{0} ", i);
            }
        }
    }
}
/*
Output: 
9 99 3 33 5 55 Iterate through each element in numbers2D2 and print values.
8 88 2 22 4 44 

    */
