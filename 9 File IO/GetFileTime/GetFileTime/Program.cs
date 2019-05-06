// SOURCE: https://www.sanfoundry.com
// AUTHOR: Sanfoundry
// FILENAME: GetFileTime
// PURPOSE: C# Program to Get File Time using File Class.
// STUDENT: Antonio Santana
// DATE: 19 April 2019
// Changes: 
using System;
using System.IO;

namespace GetFileTime
{
    class MainClass
    {
        public static void Main()
        {
            // Create info object and store info from srip.txt.
            FileInfo info = new FileInfo("C:\\srip.txt");

            // Get the file creation time.
            DateTime time = info.CreationTime;
            Console.WriteLine("File was Created at : ");
            Console.Write(time);
            Console.Read();
        }
    }
}
