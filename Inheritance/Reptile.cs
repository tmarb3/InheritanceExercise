using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public bool IsColdBlooded { get; set; }
        public bool HasScales { get; set; }

        public string Environment { get; set; }
        public string Defense { get; set; }

        public Reptile()
        {

        }


        public Reptile(string name, int age, int height, int speed, bool isColdBlooded, bool hasScales, string environment, string defense)
        {
            Name = name;
            Age = age;
            Height = height;
            Speed = speed;
            IsColdBlooded = isColdBlooded;
            HasScales = hasScales;
            Environment = environment;
            Defense = defense;



        }
    }
}
