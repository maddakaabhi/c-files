using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace acessdemo1
{
     class Program2 : Program   //consuming members of a class form child class
    {
        static void Main(string[] args)
        {
            Program2 t= new Program2();
            t.test1();
            t.test3();
            t.test4();
            t.test5();
           
        }
        
        

    }
}
