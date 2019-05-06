// SOURCE: https://www.microsoft.com
// AUTHOR: Microsoft
// FILENAME: SwitchStatement
// PURPOSE: A simple C# Program to demonstrate a switch statemenet.
// STUDENT: Antonio Santana
// DATE: 1 May 2019
// Changes: 
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
    // Create a variable of type Color.
    public enum Color { Red, Green, Blue }

    class MainClass
    {
        // Determines whether the type Color has one of three values.
        public static void Main()
        {
            // Create a local variable of the type color.
            Color c = (Color)(new Random()).Next(0, 3);

            // Evaluate each type in the c variable to determine the color.
            switch (c)
            {
                case Color.Red:
                    Console.WriteLine("The color is red");
                    break;
                case Color.Green:
                    Console.WriteLine("The color is green");
                    break;
                case Color.Blue:
                    Console.WriteLine("The color is blue");
                    break;
                default:
                    Console.WriteLine("The color is unknown.");
                    break;
            }
        }
    }
}
/*
Output:
The color is blue
 */
