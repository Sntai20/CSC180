// SOURCE: https://www.microsoft.com
// AUTHOR: Microsoft
// FILENAME: foreachSimple
// PURPOSE: A simple C# Program to demonstrate iteration logic.
// STUDENT: Antonio Santana
// DATE: 1 May 2019
// Changes: Expanded the EvenSequence parameters.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreachsimple
{
    class Program
    {
        static void Main()
        {
            // Iterate through the EvenSequence then convert to string and print to screen.
            foreach (int number in EvenSequence(0, 18))
            {
                Console.Write(number.ToString() + " ");
            }
            // Output: 0 2 4 6 8 10 12 14 16 18
            Console.ReadKey();
        }

        // Accepts two int parameters as the firstNumber and lastNumber.
        public static IEnumerable<int>
    EvenSequence(int firstNumber, int lastNumber)
        {
            // Declare number as an int and assign the firstNumber to the variable.
            // Execute the block statement as long as number is <= lastNumber.
            // Increment the counter number.
            for (int number = firstNumber; number <= lastNumber; number++)
            {
                // As long as the number is divisible by 2 return the even numbers.
                if (number % 2 == 0)
                {
                    yield return number;
                }
            }
        }
    }
}
/*
Output:
0 2 4 6 8 10 12 14 16 18 
    */

