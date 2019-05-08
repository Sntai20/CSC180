// SOURCE: https://www.microsoft.com
// AUTHOR: Microsoft
// FILENAME: DoWhile
// PURPOSE: A simple C# Program to demonstrate iteration logic.
// STUDENT: Antonio Santana
// DATE: 1 May 2019
// Changes: 
using System;

namespace DoWhile
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Declare and initialize the counter.
            int counter = 0;

            // Execute the statement once, then as long as the condition
            // evaluate to true continue to iterate.
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                // Increment the counter by one. 
                counter++;
            } while (counter < 10);
        }
    }
}
/*
Output:
Hello World! The counter is 0
Hello World! The counter is 1
Hello World! The counter is 2
Hello World! The counter is 3
Hello World! The counter is 4
Hello World! The counter is 5
Hello World! The counter is 6
Hello World! The counter is 7
Hello World! The counter is 8
Hello World! The counter is 9

Press any key to continue...
    */
