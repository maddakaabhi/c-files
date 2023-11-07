using System;
using System.Collections.Generic;
using System.Text;

namespace cfp14b
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("sum of Square of two numbers "+(Math.Pow(x,2)+Math.Pow(y,2)));
            Console.WriteLine("subtraction of Square of two numbers " + (Math.Pow(x, 2) - Math.Pow(y, 2)));


        }
    }
}
