using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1
{
    public delegate double Addnum(double x,double y);
    public class Anonynus
    {
        static void Main(string[] args)
        {
            Addnum x = delegate (double x, double y)      //anonymus method 
            {
                return x + y;

            };
            Console.WriteLine(x.Invoke(20.3, 23.3));

        }

    }
}
