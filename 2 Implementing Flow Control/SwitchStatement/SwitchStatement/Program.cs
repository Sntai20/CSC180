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
    // To mention three colors one by one, use an enum labeled Color.
    public enum Colors { Red, Green, Blue };

    class MainClass
    {
        // Determines whether the type Color has one of three values.
        public static void Main()
        {
            // Create a local variable of the type color.
            // Store a random color into the c variable. 
            Colors color = (Colors)(new Random()).Next(0, 3);

            // Evaluate each type in the c variable to determine the color.
            switch (color)
            {
                case Colors.Red:
                    Console.WriteLine("The color is red");
                    break;
                case Colors.Green:
                    Console.WriteLine("The color is green");
                    break;
                case Colors.Blue:
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
