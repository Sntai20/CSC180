﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreachMultiArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a 
            int[,] numbers2D = new int[3, 2] { { 9, 99 }, { 3, 33 }, { 5, 55 } };
            // Or use the short form:
            // int[,] numbers2D = { { 9, 99 }, { 3, 33 }, { 5, 55 } };

            foreach (int i in numbers2D)
            {
                System.Console.Write("{0} ", i);
            }
            // Output: 9 99 3 33 5 55
        }
    }
}
