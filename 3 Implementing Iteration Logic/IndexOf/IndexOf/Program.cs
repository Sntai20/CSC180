// SOURCE: https://www.dotnetperls.com/array
// AUTHOR: Sam Allen
// FILENAME: IndexOf
// PURPOSE: C# Program to demonstrate the IndexOf method.
// STUDENT: Antonio Santana
// DATE: 19 April 2019
// Changes: 

using System;

namespace IndexOf
{
    class MainClass
    {
        public static void Main()
        {
            // The program now strings inputs from the user.
            // Instead of rewriting Console.ReadLine() three
            // times, the for loop can be used to store and
            // read the strings three times in one line.
            string[] animals = new string[3];
            Console.WriteLine("Enter 3 animals:");
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i] = Console.ReadLine();
            }

            // With the animals index stored with user's input,
            // the program requests which index the user would
            // like to see (the numeric position). By typing
            // 'Cat', the program will return 1 since the Cat
            // is in index 1 of the array.
            Console.WriteLine("Which index would you like to access?");
            string input = Console.ReadLine();
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
