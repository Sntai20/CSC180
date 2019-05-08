// SOURCE: https://www.sanfoundry.com/csharp-program-atm-transaction/
// AUTHOR: Sanfoundry
// FILENAME: GetFiles
// PURPOSE: C# Program to List the Files in a Directory.
// STUDENT: Antonio Santana
// DATE: 19 April 2019
// Changes: Added GetFiles(@"C:\Users\Antonio\Documents\GitHub\CSC180\"

using System;
using System.IO;

namespace GetFiles
{
    class MainClass
    {
        public static void Main()
        {
            // Create array and get the filenames in the full path provided.
            string[] array1 = Directory.GetFiles(@"C:\Users\Antonio\Documents\GitHub\CSC180\");
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
/*
 Output:
 Files in the Directory
C:\Users\Antonio\Documents\GitHub\CSC180\.DS_Store
C:\Users\Antonio\Documents\GitHub\CSC180\README.md
 */




