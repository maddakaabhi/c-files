using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacep
{
    public class Class1: Interface1, Interface2
    {
        void Interface1.Show()
        {
            Console.WriteLine("interface1 is implemented");
        }

        void Interface2.Show()
        {
            Console.WriteLine("interface2 is implemented");
        }
        static void Main()
        {
            Class1 x= new Class1();
            //x.Show();
            Interface1 i1 = x;
            Interface2 i2 = x;
            i1.Show();
            i2.Show();
        }


    }
}
