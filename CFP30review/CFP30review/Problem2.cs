using System;
using System.Collections.Generic;
using System.Text;

namespace CFP30review
{
    internal class Problem2
    {
        public void Test2()
        {
            int a = 1;
            int b = 2;

            a = a + b;
            b = a - b;
            a = a-b;

            Console.WriteLine(" a="+a);
            Console.WriteLine(" b=" + b);

        }
    }
}
