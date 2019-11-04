using System;
using System.Collections.Generic;

namespace Inheritance_Example
{
    class Program
    {
        static void Main(string[] args)
        {

            // 3.2 Inheritance
            PrintAllAnimalProperties();
            // Polymorphism 3.3
            CreateListOfAnimalsAndPrintStats();
            //Polymorphism 3.4
            ListOfUserErrClassAndPrintProp();




           static void PrintAllAnimalProperties()
            {
                // Print Horse Properties

                Horse horse = new Horse("Horse", 50.5, 10, 120);
                Console.WriteLine(horse.Stats());

                // print Dog Properties


                Dog dog = new Dog("Dog", 30.5, 3,"black");
                Console.WriteLine(dog.Stats());

                //Print Hedgehog Properties


                Hedgehog hedgehog = new Hedgehog("Hedgehog", 10.5, 3,50);
                Console.WriteLine(hedgehog.Stats());

                // Print Bird properties.

                Bird bird = new Bird("bird", 7.5, 1,5);
                Console.WriteLine(bird.Stats());

                
            }

            static void CreateListOfAnimalsAndPrintStats()
            {
                var  animal = new List<Animal>()
                {
                    new Horse("NAPOLEON", 50.5, 10, 120),
                    new  Dog("Apollo", 30.5, 3,"black"),
                    new Hedgehog("Spiky", 10.5, 3,50),
                    new Bird("Kiwi", 7.5, 1,4),

                };

                Bird bird1 = new Bird("Joy", 6, 2,3);
                Dog dog1 = new Dog("Jimmy", 13.5, 4,"brown");

                // Add Animals to List
                animal.Add(bird1);
                animal.Add(dog1);

                // print each animal using For each.

                foreach (var animalobj in animal)
                {
                    Console.WriteLine(animalobj.Stats());
                    Console.WriteLine("---------------------------------");

                }

                // Create list object of type Dog


                //var dogslist = new List<Dog>()
                //{
                //    //new Horse("Pepper",45.0,7),

                //}

                // Printout Stats() for only object of the type Dog using Foreach of Animals.

                foreach (var animalobj in animal)
                {
                    if (animalobj is Dog dogobj)
                    {
                        Console.WriteLine("The Dog object ");
                        Console.WriteLine(animalobj.Stats());
                        dogobj.Speak();

                    }
                    // animalobj.Speak();
                }
            }

            static void ListOfUserErrClassAndPrintProp()
            {
                var error = new List<UserError>()
                  {
                        new  NumericInputError(),
                        new TextInputError(),
                        new  IndexOutofBound(),
                        new FieldLengthValidation(),
                        new ClassNotFound(),
                   };

                foreach (var err in error)
                {
                    Console.WriteLine(err.UEMessage());
                    Console.WriteLine("-----------------------------------");
                }
            }
            /* Q: Try to add an object of the type Horse to your Dog list. Why doesnt it work? */

            // Horse class does not inherit Dog class rather it inherits Animal class.

            /* Q: Which type must the List take for all your animals to be accepted. */

            // It should take Animal class.

            /* Q: Try calling the Speak method from the list Animals. Why doesnt work? */

            // Speak is a method specific to Dog class. so it doesnt work when we have the list with Animal class.


        }
    }
}
