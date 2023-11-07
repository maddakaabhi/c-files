using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application
{
    public class Rectangle : Program
    {
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.Height = height;
        }
        public override double Getarea()
        {
            return width * Height;
        }

    }

}