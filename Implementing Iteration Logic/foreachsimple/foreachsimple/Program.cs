using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreachsimple
{
    class Program
    {
        static void Main()
        {
            // Iterate through the EvenSequence then convert to string and print to screen.
            foreach (int number in EvenSequence(0, 18))
            {
                Console.Write(number.ToString() + " ");
            }
            // Output: 0 2 4 6 8 10 12 14 16 18
            Console.ReadKey();
        }

        public static System.Collections.Generic.IEnumerable<int>
    EvenSequence(int firstNumber, int lastNumber)
        {
            // Yield even numbers in the range.
            for (int number = firstNumber; number <= lastNumber; number++)
            {
                if (number % 2 == 0)
                {
                    yield return number;
                }
            }
        }
    }
}


