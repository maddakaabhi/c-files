using System;
using System.Collections.Generic;
using System.Text;

namespace Cfp
{
    public class Hello
    {
        public void greeting(string text)
        {
            Console.WriteLine("Hello " + text);
        }
    }
    public class Ex2 : Hello

    {
        static void Main()
        {
            Ex2 x = new Ex2();
            x.greeting("Good Morning");
        }
    }

}
