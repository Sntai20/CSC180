// SOURCE: https://www.sanfoundry.com/csharp-program-binaryreader/
// AUTHOR: Sanfoundry
// FILENAME: BinaryReader.cs
// PURPOSE: C# Program to Implement BinaryReader.
// STUDENT: Antonio Santana
// DATE: 19 April 2019

using System;
using System.IO;

namespace BinaryReaderApp
{
        class MainClass
        {
        const string fileName = "program.dat";
        static void Main()
        {
            Write();
            Console.WriteLine("Using Binary Writer Class the Contents are Written ");
            Display();
        }

        // Use BinaryWriter and create file with the contents below.
        public static void Write()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName,
                                                           FileMode.Create)))
            {
                writer.Write(1.250F);
                writer.Write(@"C:\Temp");
            }
        }

        // Check to see if the file exists.
        public static void Display()
        {
            float aspectRatio;
            string tempDirectory;
            if (File.Exists(fileName))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(fileName,
                                                                 FileMode.Open)))
                {
                    aspectRatio = reader.ReadSingle();
                    tempDirectory = reader.ReadString();
                }
                Console.WriteLine("Aspect Ratio Set to : " + aspectRatio);
                Console.WriteLine("Temp Directory is : " + tempDirectory);
                Console.Read();
            }
        }
    }
}
