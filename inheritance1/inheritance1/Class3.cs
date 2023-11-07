using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance1
{
    public class Class3 : Class2  
    {
        public void Test3()
        {
            Console.WriteLine("method 3 is executed");
        }
        static void Main(string[] args)
        {
            //object obj = new object();
            //Console.WriteLine(obj.GetType());
            //Class1 x = new Class1();   //class1 contains 6 methods
            //Console.WriteLine(x.GetType());
            //Class2 y = new Class2();   // class2 contains 7 methods
            //Console.WriteLine(y.GetType());
            Class3 z = new Class3();
            Console.WriteLine(z.GetType());                //class3 contains 8 methods
            
        }
    }
}
