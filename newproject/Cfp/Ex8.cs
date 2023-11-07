using System;
using System.Collections.Generic;
using System.Text;

namespace Cfp
{
    public abstract class Ex8
    {
        public abstract void greet(string a);
        
    }

    public class Reference:Ex8
    {
        int y;
        public override void greet(string s)
        {
            Console.WriteLine(s);
        }

        static void Main(string[] args)
        {
            Reference r = new Reference();
            r.y= 5;      //value type
            r.greet("Hello");
            Ex8 p =r;   //reference type
            p.greet("Good Morning");
            

        }

    }
}
