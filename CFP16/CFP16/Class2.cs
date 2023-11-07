using System;
using System.Collections.Generic;
using System.Text;

namespace CFP16
{
    internal class Class2
    {
        public void Test()
        {
            Console.WriteLine("enter int elements");
            int x=int.Parse(Console.ReadLine());
            int y=int.Parse(Console.ReadLine());
            int z=int.Parse(Console.ReadLine());
            if (x > y && x > z) { Console.WriteLine($"{x} is greater than {y} and {z}"); }
            else if(y>z) { Console.WriteLine($"{y} is greater than {x} and {z}"); }
            else{ Console.WriteLine($"{z} is greater than {x} and {y}"); }


            Console.WriteLine("enter double elements");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a > b && a > c) { Console.WriteLine($"{a} is greater than {b} and {c}"); }
            else if (b > c) { Console.WriteLine($"{b} is greater than {a} and {c}"); }
            else { Console.WriteLine($"{c} is greater than {a} and {b}"); }

        }

    }
}
