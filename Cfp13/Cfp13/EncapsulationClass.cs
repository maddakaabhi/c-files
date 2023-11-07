using System;
using System.Collections.Generic;
using System.Text;

namespace Cfp13
{
    public class EncapsulationClass
    {
        static void Main(string[] args) 
        {
            Encapsulation x = new Encapsulation(1, "Abhi", "engineer");
            Encapsulation y = new Encapsulation(2, "Hi", "doctor");

            Console.WriteLine(x.id);
            Console.WriteLine(x.name);
            x.name = "Hello";
            Console.WriteLine(x.name);
            Console.WriteLine(x.role);


            Console.WriteLine(y.id);
            Console.WriteLine(y.name);
            y.name = "good";
            Console.WriteLine(y.name);
            Console.WriteLine(y.role);

            


        }

    }
}
