// SOURCE: https://www.microsoft.com
// AUTHOR: Microsoft
// FILENAME: HashSet
// PURPOSE: C# Program to creates two HashSet<T> objects.
// STUDENT: Antonio Santana
// DATE: 1 May 2019
// Changes: 
// To merge two disparate sets this example creates two HashSet<T> objects, and 
// populates them with even and odd numbers, respectively. A third HashSet<T> 
// object is created from the set that contains the even numbers. 
// The example then calls the UnionWith method, which adds the odd number set to the third set.
using System;
using System.Collections.Generic;

namespace HashSet
{
    class MainClass
    {
        public static void Main()
        {
            HashSet<int> evenNumbers = new HashSet<int>();
            HashSet<int> oddNumbers = new HashSet<int>();

            for (int i = 0; i < 5; i++)
            {
                // Populate numbers with just even numbers.
                evenNumbers.Add(i * 2);

                // Populate oddNumbers with just odd numbers.
                oddNumbers.Add((i * 2) + 1);
            }

            Console.Write("evenNumbers contains {0} elements: ", evenNumbers.Count);
            DisplaySet(evenNumbers);

            Console.Write("oddNumbers contains {0} elements: ", oddNumbers.Count);
            DisplaySet(oddNumbers);

            // Create a new HashSet populated with even numbers.
            HashSet<int> numbers = new HashSet<int>(evenNumbers);
            Console.WriteLine("numbers UnionWith oddNumbers...");
            numbers.UnionWith(oddNumbers);

            Console.Write("numbers contains {0} elements: ", numbers.Count);
            DisplaySet(numbers);

        }

        private static void DisplaySet(HashSet<int> set)
        {
            Console.Write("{");
            foreach (int i in set)
            {
                Console.Write(" {0}", i);
            }
            Console.WriteLine(" }");
        }
    }
}
/* 
 * Output:
 * evenNumbers contains 5 elements: { 0 2 4 6 8 }
 * oddNumbers contains 5 elements: { 1 3 5 7 9 }
 * numbers UnionWith oddNumbers...
 * numbers contains 10 elements: { 0 2 4 6 8 1 3 5 7 9 }
 */
