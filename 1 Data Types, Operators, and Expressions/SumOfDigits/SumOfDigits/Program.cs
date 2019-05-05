// SOURCE: Hands-On Object-Oriented Programming with C#
// AUTHOR: Raihan Taher
// FILENAME: SumOfDigits
// PURPOSE: C# Program to add the digits of a number.
// STUDENT: Antonio Santana
// DATE: 5 April 2019
// Changes: Added a public access modifier to main.

using System;

namespace SumOfDigits
{
    class MainClass
    {
        // The entry point of the program.
        public static void Main(string[] args)
        {
            // Execute as long as the if statement at the end is true.
            while (true)
            {
                // Declaring sum as a long equivalent to 0.
                long sum = 0;

                // Request user to input numbers for the program to calculate.
                Console.WriteLine("Enter a Number : ");

                // Converts the user's input from a string to a long variable type.
                // Long data types are whole number w/ bigger values than ints.
                long num = long.Parse(Console.ReadLine());

                // Execute the following code, as long as num is not equal to 0.
                while (num != 0)
                {
                    // r is the remainder of the user's number when divided by 10.
                    long r = num % 10;

                    // num is then divided by 10.
                    num = num / 10;

                    // r is added to the sum.
                    sum = sum + r;

                    Console.WriteLine("sum = {0}", sum);
                }

                // Program shows the user the sum of digits in a number.
                Console.WriteLine("Sum of Digits of the Number : " + sum);

                // Program gives user choice to enter another number to calculate.
                Console.WriteLine("Try again?  (Y/N) ");

                // Program will loop if user enters "y".
                if (Console.ReadLine().ToLower() != "y")
                    break;
                // Will break loop if the user enters anything other than "y".
            }
        }
    }
}
/*
         Output:
            Enter a Number : 
            9
            sum = 9
            Sum of Digits of the Number : 9
            Try again? (Y/N)         
      */



