using System;

namespace SOReverseMe
{
    class MainClass
    {
        public static void Main()
        {
            string inputString = "htrae no nam tsehcir ehT";
            string outputString = ReverseString(inputString);

            Console.WriteLine("Original String: " + inputString); 
            Console.WriteLine(outputString);

            Console.ReadLine();
        }
     

        private static string ReverseString(string inputString)
        {
            string reversedString = "";

            for(int count=inputString.Length-1;count >= 0; count--)
            {
                reversedString += inputString[count];
            }

            return reversedString;
        }
    }
}

