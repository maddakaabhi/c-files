using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1          //multicast delegates   adding more than one method to a single delegate
{
    public delegate void getdelegate(double x, double y);
    public class Rectanglemulticast
    {
        public void getarea(double x, double y)
        {
            Console.WriteLine("area of rectangle :" + (x + y));
        }
        public void getperimeter(double x, double y)
        {
            Console.WriteLine("perimeter of rectangle :" + (2 * (x + y)));
        }
        static void Main(string[] strings)
        {
            Rectanglemulticast rect = new Rectanglemulticast();
            rect.getarea(12.24, 11.24);         //calling method using instances
            rect.getperimeter(12.24, 11.24);

            Console.WriteLine("\n");

            getdelegate x = rect.getarea;  //a way of adding reference of method
            x += rect.getperimeter;        // adding one more reference of method

            x.Invoke(12.24, 11.24);
        }
    }
}
