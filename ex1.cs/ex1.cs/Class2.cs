using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1.cs
{
    public class Class2:Class1
    {
        public Class2() : base(10) {
            Console.WriteLine("Hello world");
        }
        static void Main(string[] args)
        {
           Class2 x= new Class2();
        }
        
    }
}
