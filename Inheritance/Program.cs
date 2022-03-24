using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Done - Create a class Animal
            // Done - give this class 4 members that all Animals have in common


            // Done - Create a class Bird
            // Done - give this class 4 members that are specific to Bird
            // Done - Set this class to inherit from your Animal Class

            // Done - Create a class Reptile
            // Done - give this class 4 members that are specific to Reptile
            // Done - Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Bird redBird = new Bird()
            {
                Name = "reddy",
                Age = 3,
                Height = 4,
                Speed = 5,
                Wings = "long",
                Color = "red",
                Type = "Bird",
                IsWarmBlooded = true,



            };

            Console.WriteLine($"{redBird.Name} is the name, I am a {redBird.Type} that is {redBird.Age} years old." + 
                $"My wings are {redBird.Wings} and they are {redBird.Color}.");
            Console.WriteLine($"On a scale from 1-10, my height is a {redBird.Height} and my speed is a {redBird.Speed}.");
            Console.WriteLine($"It is {redBird.IsWarmBlooded} that I am warm blooded.");

            Console.WriteLine("--------------------");
            Reptile lizard = new Reptile()
            {
                Name = "lizzy",
                Age = 3,
                Height = 1,
                Speed = 3,
                IsColdBlooded = true,
                HasScales = false,
                Environment = "yard",
                Defense = "hiss",



            };
          
            Console.WriteLine($"{lizard.Name} is the name, I am a lizard that is {lizard.Age} years old." +
                $"I live in the {lizard.Environment} and my defense is to {lizard.Defense}.");
            Console.WriteLine($"On a scale from 1-10, my height is a {lizard.Height} and my speed is a {lizard.Speed}.");
            Console.WriteLine($"It is {lizard.IsColdBlooded} that I am cold blooded, and {lizard.HasScales} that I have scales.");




        }
    }
}
