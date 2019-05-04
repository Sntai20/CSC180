// SOURCE: https://www.microsoft.com
// AUTHOR: Microsoft
// FILENAME: foreachMultiArray
// PURPOSE: A simple C# Program to demonstrate iteration logic with 2D array.
// STUDENT: Antonio Santana
// DATE: 1 May 2019
// Changes: 

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
            // Or use the short form:
            // int[,] numbers2D = { { 9, 99 }, { 3, 33 }, { 5, 55 } };

            // Iterate through each element in both arrays and print values.
            foreach (int i in numbers2D)
            {
                System.Console.Write("{0} ", i);
            }
            // Output: 9 99 3 33 5 55
        }
    }
}
