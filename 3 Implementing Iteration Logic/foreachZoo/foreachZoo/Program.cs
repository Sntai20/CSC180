// SOURCE: https://www.microsoft.com
// AUTHOR: Microsoft
// FILENAME: foreachZoo
// PURPOSE: C# Program to demonstrate iteration with methods, class, and lists.
// STUDENT: Antonio Santana
// DATE: 1 May 2019
// Changes: 

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreachZoo
{
    class MainClass
    {
        static void Main()
        {
            // Create new local object theZoo, then add mammals and birds.
            Zoo theZoo = new Zoo();

            theZoo.AddMammal("Whale");
            theZoo.AddMammal("Rhinoceros");
            theZoo.AddBird("Penguin");
            theZoo.AddBird("Warbler");

            // Iterate through each name in the theZoo.
            foreach (string name in theZoo)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();

            // Iterate through bird names in theZoo.
            foreach (string name in theZoo.Birds)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();

            // Iterate through mammal names in theZoo.
            foreach (string name in theZoo.Mammals)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        // Create a Zoo class.
        public class Zoo : IEnumerable
        {
            // Create a Private list of animal members.
            private List<Animal> animals = new List<Animal>();

            // Public methods.
            public void AddMammal(string name)
            {
                animals.Add(new Animal { Name = name, Type = Animal.TypeEnum.Mammal });
            }

            public void AddBird(string name)
            {
                animals.Add(new Animal { Name = name, Type = Animal.TypeEnum.Bird });
            }

            public IEnumerator GetEnumerator()
            {
                foreach (Animal theAnimal in animals)
                {
                    yield return theAnimal.Name;
                }
            }

            // Public members.
            public IEnumerable Mammals
            {
                get { return AnimalsForType(Animal.TypeEnum.Mammal); }
            }

            public IEnumerable Birds
            {
                get { return AnimalsForType(Animal.TypeEnum.Bird); }
            }

            // Private methods.
            private IEnumerable AnimalsForType(Animal.TypeEnum type)
            {
                foreach (Animal theAnimal in animals)
                {
                    if (theAnimal.Type == type)
                    {
                        yield return theAnimal.Name;
                    }
                }
            }

            // Create a private animial class.
            private class Animal
            {
                public enum TypeEnum { Bird, Mammal }
                public string Name { get; set; }
                public TypeEnum Type { get; set; }
            }
        }
    }
}
/*
Output: 
Whale Rhinoceros Penguin Warbler
Penguin Warbler
Whale Rhinoceros
    */
