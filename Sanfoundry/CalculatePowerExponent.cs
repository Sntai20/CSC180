/*
 *  C# Program to Calculate the power exponent value
 */
using System;
class Program
{
    static void Main()
    {
 
        double m, n;
        Console.WriteLine("Enter the Number : ");
        m = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Exponent : ");
        n = double.Parse(Console.ReadLine());
        double value1 = Math.Pow(m, n);
        Console.WriteLine("Result : {0}", value1);
        Console.ReadLine();
    }
}