// SOURCE: https://www.microsoft.com
// AUTHOR: Microsoft
// FILENAME: ArrayTests
// PURPOSE: C# Program creates single-, multi- dimensional, and jagged arrays.
// STUDENT: Antonio Santana
// DATE: 1 May 2019
// Changes: Added a two foreach loops and a two arrays.
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTests
{
    class MainClass
    {
        public static void Main()
        {
            // Declare a single-dimensional array. 
            int[] array1 = new int[5];

            // Declare and set array element values.
            int[] array2 = new int[] { 1, 3, 5, 7, 9 };

            // Short version to declare an array.
            int[] array3 = { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine("Iterate through the array named numbers " +
                "and print each element.");

            // Iterate through the array named numbers and print each element.
            int[] numbers = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };
            foreach (int i in numbers)
            {
                Console.Write("{0} ", i);
            }

            // Declare a two dimensional array, seperate elements with commas.
            int[,] multiDimensionalArray1 = new int[2, 3];

            // Declare and set array element values.
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            Console.WriteLine("\nIterate through the numbers2D array and " +
                "print each element.");

            // Iterate through the numbers2D array and print each element.
            int[,] numbers2D = new int[3, 2] { { 9, 99 }, { 3, 33 }, { 5, 55 } };
            // Or use the short form:
            // int[,] numbers2D = { { 9, 99 }, { 3, 33 }, { 5, 55 } };

            foreach (int i in numbers2D)
            {
                Console.Write("{0} ", i);
            }

            // Declare a jagged array.
            int[][] jaggedArray = new int[6][];

            // Set the values of the first array in the jagged array structure.
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
        }
    }
}
/*
Output:
Iterate through the array named numbers and print each element.
4 5 6 1 2 3 -2 -1 0 
Iterate through the numbers2D array and print each element.
9 99 3 33 5 55 
 */
