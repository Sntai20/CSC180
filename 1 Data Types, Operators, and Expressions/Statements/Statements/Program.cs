// SOURCE: https://www.microsoft.com
// AUTHOR: Microsoft
// FILENAME: Statements
// PURPOSE: A simple C# Program to demonstrate statements.
// STUDENT: Antonio Santana
// DATE: 10 April 2019
// Changes: 

using System;

namespace Statements
{
    class MainClass
    {
        public static void Main()
        {
            // Declaration statement.
            int counter;

            // Assignment statement.
            counter = 1;

            // Declaration statements with initializers condensed to one line.         
            // Declare and initialize an array.
            int[] radii = { 15, 32, 108, 74, 9 };

            // Declare and initialize constant, so it can not be changed.
            const double pi = 3.14159;           

            // foreach statement block that contains multiple statements.
            foreach (int radius in radii)
            {
                // Declaration statement with initializer.
                double circumference = pi * (2 * radius);

                // Expression statement can span multiple lines. Line breaks
                // are treated as white space and ignored by the compiler.
                System.Console.WriteLine("Radius of circle #{0} is {1}. Circumference = {2:N2}",
                                        counter, radius, circumference);

                // Expression statement (postfix increment).
                counter++;

            } // End of foreach statement block
        } // End of Main method body.
    } // End of SimpleStatements class.
      /*
         Output:
          Radius of circle #1 = 15. Circumference = 94.25
          Radius of circle #2 = 32. Circumference = 201.06
          Radius of circle #3 = 108. Circumference = 678.58
          Radius of circle #4 = 74. Circumference = 464.96
          Radius of circle #5 = 9. Circumference = 56.55
      */
}



