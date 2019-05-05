// SOURCE: https://www.sanfoundry.com/csharp-program-atm-transaction/
// AUTHOR: Sanfoundry
// FILENAME: GetFiles
// PURPOSE: C# Program to List the Files in a Directory.
// STUDENT: Antonio Santana
// DATE: 19 April 2019
// Changes:

using System;
using System.IO;

namespace GetFiles
{
    class MainClass
    {
        public static void Main()
        {
            // Create array of filenames.
            string[] array1 = Directory.GetFiles(@"D:\");
            Console.WriteLine("Files in the Directory");

            // To print to screen iterate through the array of names.
            foreach (string name in array1)
            {
                Console.WriteLine(name);
            }
            Console.Read();
        }
    }
}




