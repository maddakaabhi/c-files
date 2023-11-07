using System;
using System.Collections.Generic;
using System.Text;

namespace Cfp13
{
    public abstract class Abstraction
    {
        public const double pi = 3.14;
        public abstract double getarea();
    }

    public class Rectangle : Abstraction
    {
        public double length { get; set; }
        public double bredth { get; set; }

        public override double getarea()
        {
            return length * bredth;
        }
    }
    public class Circle : Abstraction 
    {
        public double radius { get; set; }
        public override double getarea()
        {
            return pi * radius * radius;
        }

    }
}
