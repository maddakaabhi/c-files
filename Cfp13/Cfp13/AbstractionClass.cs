using System;
using System.Collections.Generic;
using System.Text;

namespace Cfp13
{
    public  class AbstractionClass
    {
        static void Main(string[] args)
        {
            Rectangle x = new Rectangle();
            x.length = 10;
            x.bredth = 5;
            Console.WriteLine("The area of Rectangle is "+x.getarea());

            Circle y = new Circle();
            y.radius = 10;
            Console.WriteLine("The area of circle is "+y.getarea());
        }
    }
}
