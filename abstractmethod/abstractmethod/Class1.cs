using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractmethod
{
    public class Class1 : Abstractm
    {
        public override void div(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        public override void sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            Abstractm m = c;
            c.div(1, 2);
            c.mul(2, 3);
            c.sub(3, 4);
            c.add(4, 5);
            Console.WriteLine("\n");
            m.div(1, 2);
            m.sub(2, 3);
            m.mul(3, 4);
            m.add(4, 5);
        }
    }
}
