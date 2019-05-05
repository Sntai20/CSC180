// SOURCE: https://www.sanfoundry.com/csharp-program-binaryreader/
// AUTHOR: Sanfoundry
// FILENAME: BinaryReader.cs
// PURPOSE: C# Program to Convert Decimal to Binary.
// STUDENT: Antonio Santana
// DATE: 19 April 2019

using System;

namespace DecimalToBinary
{
    class MainClass
    {
        /// <summary>
        /// Convert Decimal to Binary.
        /// </summary>
        public static void Main()
        {
            // Declare num as int and ask for user input.
            int num;
            Console.Write("Enter a Number : ");
            num = int.Parse(Console.ReadLine());

            // Declare quot and rem.
            int quot;
            string rem = "";

            // Validate input is greater than or equal to 1.
            while (num >= 1)
            {
                quot = num / 2;

                // Remainder operator % computes the base 2 position.
                rem += (num % 2).ToString();
                num = quot;
            }

            // Create binary string and store in bin.
            string bin = "";

            // Iterate through each element to create string.
            for (int i = rem.Length - 1; i >= 0; i--)
            {
                bin = bin + rem[i];
            }
            Console.WriteLine("The Binary format for given number is {0}", bin);

            //TODO create loop
            //TODO create exit option.
            Console.Read();
        }
    }
}

