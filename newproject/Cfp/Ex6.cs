using System;
using System.Collections.Generic;
using System.Text;

namespace Cfp
{
    public  class Ex6
    {
        static int x;   //static variable
        int y;          //non static variable
        const double pi = 3.14;      //Constant variable

        readonly bool flag;
        public Ex6(bool flag) 
        {
            this.flag = flag;
        }

        public static void Main(string[] args)
        {
            x = 10;
            Console.WriteLine(x);
            Ex6 p = new Ex6(true);
            p.y = 20;
            Console.WriteLine(p.y);
            Console.WriteLine(pi);
            Console.WriteLine(p.flag);
        }
    }
}
