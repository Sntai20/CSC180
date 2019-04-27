﻿// SOURCE: https://www.sanfoundry.com/csharp-program-big-little-endian/
// AUTHOR: Sanfoundry
// FILENAME: BigToLittleEndian
// PURPOSE: C# Program to Convert Big Endian to Little Endian.
// STUDENT: Antonio Santana
// DATE: 19 April 2019

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigToLittleEndian
{
    class Program
    {
        // Create an Array with bits converted from GetBytes.
        static int ReverseBytes(int val)
        {
            byte[] intAsBytes = BitConverter.GetBytes(val);

            // Reverse the intAsBytes Array and return BitConverter.
            Array.Reverse(intAsBytes);
            return BitConverter.ToInt32(intAsBytes, 0);
        }

        // Store binary string in s
        static string IntToBinaryString(int v)
        {
            string s = Convert.ToString(v, 2);
            string t = s.PadLeft(32, '0');
            string res = "";
            for (int i = 0; i < t.Length; ++i)
            {
                if (i > 0 && i % 8 == 0)
                    res += " ";
                res += t[i];
            }
            return res;
        }

        // Define little and big endian.
        static void Main(string[] args)
        {
            // TODO Create input option. 
            int little = 2777;
            int big = ReverseBytes(little);
            string sLittle = IntToBinaryString(little);
            string sBig = IntToBinaryString(big);
            int oLittle = ReverseBytes(big);
            string oString = IntToBinaryString(oLittle);
            Console.WriteLine("Original (Intel) little endian value = "
              + little);
            Console.WriteLine("Original value as binary string = "
              + sLittle);
            Console.WriteLine("");
            Console.WriteLine("Reversed big endian value = "
              + big);
            Console.WriteLine("Reversed value as string = "
              + sBig);
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}

