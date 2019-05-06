// SOURCE: https://www.tutorialspoint.com/csharp/csharp_classes.htm
// AUTHOR: TutorialsPoint
// FILENAME: BoxApplication
// PURPOSE: C# Example of an object-oriented program.
// STUDENT: Antonio Santana
// DATE: 1 May 2019
// Changes: Commented during classes and followed along with Dan.
// version: updated version that corrects a couple of bad programming practices
// modifications: eliminated public instance variables by making Box()
//     constructor that sets private fields; moved duplicate volume
//     calculations into Box.volume() method; added a few object-oriented
//     tutorial comments.

using System;

namespace BoxApplication
{
    // Created a box class to have a template which box objects can be.
    class Box
    {
        // A class can contain data items (fields and properties)
        // as well as methods (functions) that operate on that data.
        // In object-oriented terminoligy, this is called "encapsulation".

        // Length of a box
        private double length;
        // Breadth of a box
        private double breadth;
        // Height of a box
        private double height;   

        // Constructor to initialize values.
        public Box(double l, double b, double h)
        {
            this.length = l;
            this.breadth = b;
            this.height = h;
        } 

        // Get volume method.
        public double volume()
        {
            return (height * length * breadth);
        } 
    }

    // startup class... contains Main() static function
    // we normally do not create an object from the Startup class.
    // usually, it contains a few static functions that set up
    // objects that do the work of the program. the Startup class
    // is as close to an old-style procedural program as you are
    // going to get in C#.  if we don't create objects that can
    // talk to each other, we don't have an object-oriented program.
    class Boxtester
    {
        static void Main(string[] args)
        {
            // Instantiating a box object from the Box class.
            // Instantiation is a four step process:
            // 1) The new operator allocates a block of memory to hold
            //    a new object.
            // 2) The new operator invokes the specified constructor 
            //    method to initialize the object's block of memory...
            //    instance variables (fields) are set up and initial
            //    values are moved into them.
            // 3) A constructor method is unique in that it does not
            //    return a value (no return value, not even "void").
            //    this is so that the new operator can return a reference
            //    pointer that points indirectly to the newly-created
            //    object. The reference pointer is not really a memory
            //    address, but more of a way to get to that memory address.
            // 4) The assignment operator "shoves" the reference pointer
            //    into a typed variable that points to the object.

            // Instantiate box 1 & initialize it.
            Box Box1 = new Box(6.0, 7.0, 5.0);

            // Instantiate box 2 & initialize it.
            Box Box2 = new Box(12.0, 13.0, 10.0);

            // Dump out the calculated volumes of Box 1 & Box 2:
            // encapsulation is a wonderful concept that we will be
            // visiting again and again as we do object-oriented
            // programming. The important idea is that we should 
            // move as much of the code that uses the Box data into
            // Box class methods as possible.
            //
            // For example, rather than accessing the Box data in this
            // function to calculate the volume of the various boxes,
            // whereever it is needed, it is better to create a single
            // volume() method in the Box class that can be invoked
            // wherever it is needed.  (duplicated code is rarely a
            // good idea because it is too easy to proliferate
            // programming errors.)

            Console.WriteLine("Volume of Box1 : {0}", Box1.volume());
            Console.WriteLine("Volume of Box2 : {0}", Box2.volume());

            Console.Write("Press Enter to continue...");
            Console.ReadKey();
        }
    }
}
/*
    Output:
    Volume of Box1 : 210
    Volume of Box2 : 1560
 */
