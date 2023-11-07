using System;
using System.Collections.Generic;
using System.Text;

namespace CFP4_11review
{
    public abstract class Animal
    {
        public abstract void MakeSound();
        
    }
    public class Cat : Animal
    {
        public string Name { get; set; }
        public string sound { get; set; }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} makes sound {sound}");
        }

    }
    public class Dog : Animal
    {
        public string Name { get; set; }
        public string sound { get; set; }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} makes sound {sound}");
        }
    }
    public class Horse : Animal
    {
        public string Name { get; set; }
        public string sound { get; set; }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} makes sound {sound}");
        }
    }
}
