using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public string Wings { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public bool IsWarmBlooded { get; set; }

        public Bird (string name, int age, int height, int speed, string wings, string type, string color, bool isWarmBlooded)
        {
            Name = name;
            Age = age;  
            Height = height;    
            Speed = speed;
            Wings = wings;
            Type = type;
            Color = color;
            IsWarmBlooded = isWarmBlooded;
              
        }

        public Bird()
        {

        }



    }
}
