// SOURCE: https://www.microsoft.com
// AUTHOR: Microsoft
// FILENAME: BranchAndLoopsChallenge
// PURPOSE: C# Program to demonstrate iteration logic and branches.
// STUDENT: Antonio Santana
// DATE: 1 May 2019
// Changes: 

using System;

namespace BranchAndLoopsChallenge
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ExploreIf();

            // initializer: int index = 0; declares counter as a loop variable, 
            // and sets its initial value to 0.
            int counter = 0;
            // While loop.
            // Evaluate condition & execute statements until condition is false.
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }

            // initializer: int index = 0; declares counter as a loop variable, 
            // and sets its initial value to 0.
            counter = 0;
            // Execute statements, then evaluates condition & iterates 
            // until condition is false.
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            } while (counter < 10);

            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"Hello World! The index is {index}");
            }

            ChallengeAnswer();
        }

        static void ExploreIf()
        {
            // Declare variables as ints and initialize to 5 and 3.
            int a = 5;
            int b = 3;
            // Evaluate the condition then print out the results.
            if (a + b > 10)
            {
                Console.WriteLine("The answer is greater than 10");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
            }

            // Declare variable as an int and initialize to 4.
            int c = 4;
            if ((a + b + c > 10) && (a > b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is greater than the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not greater than the second");
            }

            if ((a + b + c > 10) || (a > b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is greater than the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not greater than the second");
            }
        }

        static void ChallengeAnswer()
        {
            int sum = 0;
            // For loop.
            // Three parts that control are initializer, condition, and iterator.
            // iterator: index++ specifies how to modify the loop variable
            // after executing the block following the for statement. 
            // index should be incremented by 1 each time the block executes.
            for (int number = 1; number < 21; number++)
            {
                if (number % 3 == 0)
                {
                    sum = sum + number;
                }
            }
            Console.WriteLine($"The sum is {sum}");
        }

    }
}
/*
Output:
The answer is not greater than 10
The answer is greater than 10
And the first number is greater than the second
The answer is greater than 10
Or the first number is greater than the second
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
Hello World! The index is 0
Hello World! The index is 1
Hello World! The index is 2
Hello World! The index is 3
Hello World! The index is 4
Hello World! The index is 5
Hello World! The index is 6
Hello World! The index is 7
Hello World! The index is 8
Hello World! The index is 9
The sum is 63
    */
