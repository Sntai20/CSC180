// SOURCE: https://www.sanfoundry.com
// AUTHOR: Sanfoundry
// FILENAME: CalculatePermutations
// PURPOSE: C# Program to calculate permutations.
// STUDENT: Antonio Santana
// DATE: 19 April 2019
// Changes: Added public access modifier, P(n,r)=, and expected output.
// Console.WriteLine($"P(n,r) = {fact} / {fact1}");
// Console.WriteLine("P(n,r) = {0}", per);
using System;

namespace CalculatePermutations
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Declare variables as integers.
            int n, r, per, fact, fact1;

            // Request user input, convert ToInt32, and store values in variables.
            Console.WriteLine("Enter the Value of 'n' and 'r' " +
                              "to find the Permutation :");
            n = Convert.ToInt32(Console.ReadLine());
            r = Convert.ToInt32(Console.ReadLine());

            // Assign factorial to n.
            fact = n;

            // Iterate through each permutation.
            // Initializer subtracts 1 from the factorial.
            // Iterator executes until the initialier is >= 1.
            // Counter subtracts 1 each iteration.
            for (int i = n - 1; i >= 1; i--)
            {
                fact = fact * i;
            }

            // Declare variable as an integer.
            int number;

            // Perform 
            number = n - r;
            fact1 = number;

            // Iterate through each permutation.
            // Initializer subtracts 1 from the factorial.
            // Iterator executes until the initialier is >= 1.
            // Counter subtracts 1 each iteration.
            for (int i = number - 1; i >= 1; i--)
            {
                fact1 = fact1 * i;
            }

            // Calculate the permutation and output to screen.
            per = fact / fact1;
            Console.WriteLine($"P(n,r) = {fact} / {fact1}");
            Console.WriteLine("P(n,r) = {0}", per);
            Console.ReadLine();
        }
    }
}
/*
        Output:
        Enter the Value of 'n' and 'r' to find the Permutation :
        10
        4
        P(n,r) = 3628800 / 720
        P(n,r) = 5040        
      */




