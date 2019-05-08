// SOURCE: https://www.sanfoundry.com
// AUTHOR: Sanfoundry
// FILENAME: GetFileTime
// PURPOSE: C# Program to Get File Time using File Class.
// STUDENT: Antonio Santana
// DATE: 19 April 2019
// Changes: Added FileInfo info = new FileInfo(@"C:\Users\Antonio\Desktop\srip.txt");
using System;
using System.IO;

namespace GetFileTime
{
    class MainClass
    {
        public static void Main()
        {
            // Create info object and store info from srip.txt.
            FileInfo info = new FileInfo(@"C:\Users\Antonio\Desktop\srip.txt");

            // Get the file creation time and store the value in time.
            DateTime time = info.CreationTime;
            Console.WriteLine("File was Created at : ");
            Console.Write(time);
            Console.Read();
        }
    }
}
/*
Output:
File was Created at :
12/31/1600 4:00:00 PM
*/
