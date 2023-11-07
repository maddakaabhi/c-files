using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance1
{
    public class Class2 : Class1
    {
        public void  Test4()
        {
            Console.WriteLine("constructor 2 is executed");
        }
        static void Main(string[] args)
        {
            Class2 p= new Class2();
            p.Test1();
            p.Test2();
            p.Test4();
        }

    }
}
