// SOURCE: https://www.sanfoundry.com
// AUTHOR: Sanfoundry
// FILENAME: FahrenheitToCelsius
// PURPOSE: C# Program to Convert Fahrenheit to Celsius.
// STUDENT: Antonio Santana
// DATE: 19 April 2019

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FahrenheitToCelsius
{
    class Celsius
    {
        static void Main(string[] args)
        {
            // Declare celsius as double and ask for user input.
            double celsius;
            Console.Write("Enter Fahrenheit temperature : ");

            // Declare fahrenheit as double, store user input into fahrenheit.
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            // Convert fahrenheit to celsius and provide user output.
            celsius = (fahrenheit - 32) * 5 / 9;

            //TODO clean up output
            Console.WriteLine("The converted Celsius temperature is" + celsius);

            //TODO create loop
            //TODO create exit statement.
            Console.ReadLine();
        }
    }
}
