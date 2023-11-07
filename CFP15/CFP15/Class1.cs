using System;
using System.Collections.Generic;
using System.Text;

namespace CFP15
{
    public class Class1
    {
        public static bool Test<T>(T a,T b)  //generic method
        {
            bool c= a.Equals(b);
            return c;
        }
    }
}
