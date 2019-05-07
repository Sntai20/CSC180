using System;

namespace DoWhile
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int counter = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            } while (counter < 10);
        }
    }
}
