using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Example
{
    class Animal
    {
        protected string name;
        protected double weight;
        protected int age;
        public string Name
        {
            get
            {
                return name;
            }
  
        }
        public double Weight {
            get
            {
                return weight;
            }
          }
        public double Age
        {
            get
            {
                return age;
            }
        }
        public Animal(string name, double weight, int age)
        {
            this.name = name;
            this.weight = weight;
            this.age = age;
        }

        public virtual string Stats()
        {
            
            return $"Name: {this.name} Weight: {this.weight} Age: {this.age}";
        }
    }

    class Horse : Animal
    {
        public Horse(string name, double weight, int age, int height) : base(name, weight, age)
        {
           
            Height = height;
        }

        public int Height { get; }

        public override string Stats()
        {
            return base.Stats() + $"Hight {Height}!";
        }
        public void VisionPower()
        {
            Console.WriteLine("Almost 360 degree vision");
        }

    }


    class Dog : Animal
    {
        public Dog(string name, double weight, int age,string color) : base(name, weight, age)
        {
            Color = color;
        }
        public string Color { get; }
        public override string Stats()
        {
            return base.Stats() + $"Color {Color}!";
        }
        public void Smart()
        {
            Console.WriteLine("As smart as 2 year old toddler");
        }

        public void Speak()
        {
            Console.WriteLine("Woff Woff !!");
        }
              
    }
    class Hedgehog : Animal
    {
        public Hedgehog(string name, double weight, int age,int noofSpike) : base(name, weight, age)
        {
            NoofSpike = noofSpike;
     
        }

        public int NoofSpike{ get; }
        public override string Stats()
        {
            return base.Stats() + $"NoofSpike { NoofSpike}!"; ;
        }
        public void Quills()
        {
            Console.WriteLine("Quill is very soft ");
        }
    }
    class Bird : Animal
    {
        public Bird(string name, double weight, int age, int wingspan) : base(name, weight, age)
        {
            WingSpan = wingspan;
        }

       public int WingSpan { get; }
       public override string Stats()
        {
            return base.Stats() + $"  WingSpan {WingSpan}!"; 
        }
        public virtual string Fly()
        { 
            return "Birds can fly";
        }

    class Pelican : Bird
        {
            public Pelican(string name, double weight, int age,int wingspan,String beak) : base(name, weight, age,wingspan) 
            {
                Beak = beak;
            }

            public string Beak { get; }

            public override string Fly()
            {
                return base.Fly() + $" {Beak}";
            }
            
        }

        class Flemingo : Bird
        {
            public Flemingo(string name, double weight, int age,int wingspan,string Standing) : base(name, weight, age,wingspan)
            {
                StandingPosition = Standing;
            }

            public string StandingPosition { get; }

            public override string Fly()
            {
                return base.Fly() + $" {StandingPosition}";
            }
            
        }
        class Swan : Bird
        {
            public Swan(string name, double weight, int age,int wingspan,string capabality) : base(name, weight, age,wingspan) 
            {
                Capability = capabality;
            }

            public string Capability { get; }

            public override string Fly()
            {
                return base.Fly() + $" {Capability}";
            }

        }
    }
}

/*Q:If we at some point reach the conclusion that all birds should have an additional
    property, in which class should we add it?*/

    //  For all additional property of Birds - We can add a new property in Bird class named Uniquness, which can be overriden in all inherited classes of Bird.

/*Q:If the new property should be used for all animals, in which class should we then add it? */

    // *New  property for all the class can be defined in Animal class .

 /*Q: Why is polymorphism important? */
 /*Q: How can polymorphism be used to write cleaner and better code? */
    //1. It helps to avoid redundancy of code.
    //2. Plymorphism is much useful when we have multiple class inheriting the base class or interface or abstract class with each class having different implementation.

 /*Q: What is the difference between an abstract class and interface? */
     //Abstract and Interface and similiar in a way that we should have only have signature of medhod and properties but we should write the actual implementaion in derived class.
     //Abstract cannot be instantiated but interface can be instantiated.
     //Abstract class can hold both abstract method and other methods,but it is must that the derived class should use the abstract method, may or may not use the non abstract methods.

  



   
