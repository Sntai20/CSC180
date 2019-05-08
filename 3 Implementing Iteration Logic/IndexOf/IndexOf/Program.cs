// SOURCE: https://www.dotnetperls.com/array
// AUTHOR: Sam Allen
// FILENAME: IndexOf
// PURPOSE: C# Program to demonstrate the IndexOf method.
// STUDENT: Antonio Santana
// DATE: 4 May 2019
// Changes: 

using System;

namespace IndexOf
{
    class MainClass
    {
        public static void Main()
        {
            // Ask for user input.
            string[] animals = new string[3];
            Console.WriteLine("Enter 3 animals:");

            // Read the user input and store in string array.
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i] = Console.ReadLine();
            }

            // Ask for user input and store value in input.
            Console.WriteLine("Which index would you like to access?");
            string input = Console.ReadLine();

            // Pass the input to search for the element and print the value.
            int inputIndex = Array.IndexOf(animals, input);
            Console.WriteLine(inputIndex);

            Console.ReadLine();

        }
    }
}
/*
        Modified Output:
        Enter 3 animals:
        Dog
        Cat
        Bat
        Which index would you like to see?
        Cat
        1
        As with the original program, if the
        program attempts to access an index value
        that's not within the array (0-2), the
        program will output -1.
*/
