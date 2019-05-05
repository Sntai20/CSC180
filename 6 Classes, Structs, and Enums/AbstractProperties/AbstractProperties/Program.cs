// SOURCE: https://www.sanfoundry.com/csharp-program-class-abstract/
// AUTHOR: Sanfoundry
// FILENAME: AbstractProperties
// PURPOSE: C# Program to Demonstrate Abstract Properties.
// STUDENT: Antonio Santana
// DATE: 19 April 2019

using System;

namespace AbstractProperties
{
    public class TestClass
    {
        public static void Main()
        {
            Shape[] shapes =
            {
            new Square(5, "Square #1"),
            new Circle(3, "Circle #1"),
            new Rectangle( 4, 5, "Rectangle #1")
            };

            System.Console.WriteLine("Shapes Collection");
            foreach (Shape s in shapes)
            {
                System.Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }

    // Abstract class used for reference.
    public abstract class Shape
    {
        private string myId;

        public Shape(string s)
        {
            Id = s;
        }

        public string Id
        {
            get
            {
                return myId;
            }

            set
            {
                myId = value;
            }
        }
        public abstract double Area
        {
            get;
        }

        public override string ToString()
        {
            return Id + " Area = " + string.Format("{0:F2}", Area);
        }
    }

    // Square class inherits id, area from the shape class. 
    public class Square : Shape
    {
        private int mySide;

        public Square(int side, string id)
            : base(id)
        {
            mySide = side;
        }

        public override double Area
        {
            get
            {
                // Given the side, return the area of a square:
                return mySide * mySide;
            }
        }
    }

    // Circle class inherits id, area from the shape class.
    public class Circle : Shape
    {
        private int myRadius;

        public Circle(int radius, string id)
            : base(id)
        {
            myRadius = radius;
        }

        public override double Area
        {
            get
            {
                // Given the radius, return the area of a circle:
                return myRadius * myRadius * System.Math.PI;
            }
        }
    }

    // Rectangle class inherits id, area from the shape class.
    public class Rectangle : Shape
    {
        private int myWidth;
        private int myHeight;

        public Rectangle(int width, int height, string id)
            : base(id)
        {
            myWidth = width;
            myHeight = height;
        }

        // Override seems to be duplicated. 
        public override double Area
        {
            get
            {
                // Given the width and height, return the area of a rectangle:
                return myWidth * myHeight;
            }
        }
    }
}



 


