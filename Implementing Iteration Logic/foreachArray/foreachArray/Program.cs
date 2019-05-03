using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreachArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array of numbers.
            int[] numbers = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };

            // Iterate through number and print to screen.
            foreach (int i in numbers)
            {
                System.Console.Write("{0} ", i);
            }
            // Output: 4 5 6 1 2 3 -2 -1 0
        }
    }
}
