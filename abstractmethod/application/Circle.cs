using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application
{
    public  class Circle : Program 
    {
        public Circle(double radius) 
        {
            this.radius = radius;
        }
        public override double Getarea()
        {
            return pi * radius*radius;
        }
        static void Main(string[] args)
        {
            Rectangle x = new Rectangle(5.43, 5.43);
            Circle y = new Circle(5.43);
            Console.WriteLine(" Area of rectangle is:" +x.Getarea()); ;
            Console.WriteLine("Area of circle is:" +y.Getarea());
        }
    }
}
