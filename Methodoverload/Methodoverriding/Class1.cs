using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodoverriding
{
    public class Class1  : Program
    {
        public override void test()                              //method is overriding from parent class
        {
            Console.WriteLine("child class is called");
        }
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            c.test();
        }
    }
}
