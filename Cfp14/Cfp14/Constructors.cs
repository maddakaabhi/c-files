using System;

namespace Cfp14
{
    public class Constructors
    {
        public string name;
        static Constructors()    //static constructor
        {
            Console.WriteLine("static constructor is executed");

        }
        public Constructors()       //Non Paramaterized constructor
        {
            Console.WriteLine("Parameterless constructor executed");
        }
        public Constructors(string name)     //Parametrized constructor
        {
            this.name = name;
            Console.WriteLine(name);
        }
    }
    public class CopyConstructor
    {
        public string greet;
        public CopyConstructor(Constructors y) 
        {
            string greet = y.name;
            Console.WriteLine("Copy constructor is executed and value of variable greet is "+ greet);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Constructors x = new Constructors();
            Constructors y = new Constructors("Hello");
            CopyConstructor x2 = new CopyConstructor(y);
        }
    }
    
}
