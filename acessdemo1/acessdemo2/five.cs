using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acessdemo2
{
    internal class five          //consuming members of a class from  non child class in second project
    {
        static void Main(string[] args)
        {
            acessdemo1.Program program = new acessdemo1.Program();
            program.test1();   //public
        }
    }
}
