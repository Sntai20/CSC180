// SOURCE: https://www.sanfoundry.com
// AUTHOR: Sanfoundry
// FILENAME: Override
// PURPOSE: C# Program to Demonstrate the concept of Overriding.
// STUDENT: Antonio Santana
// DATE: 19 April 2019
// Changes: 

using System;

// Define abstract class.
abstract class ShapesClass
{
    abstract public double Area();
}


namespace Override
{
    class Circle : ShapesClass
    {
        int radius = 0;
        public Circle(int n)
        {
            radius = n;
        }


        public override double Area()
        {
            return 3.14 * radius * radius;
        }

        static void Main()
        {
            int r;
            Console.WriteLine("Enter the Radius :");
            r = int.Parse(Console.ReadLine());
            Circle c1 = new Circle(r);
            Console.WriteLine("Area of the Circle = {0}", c1.Area());
            Console.ReadLine();
        }
    }
}




