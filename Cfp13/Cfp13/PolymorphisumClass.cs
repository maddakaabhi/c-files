using System;
using System.Collections.Generic;
using System.Text;

namespace Cfp13
{
    public class PolymorphisumClass : Polymorphisum
    {
        static void Main(string[] args)
        {
            PolymorphisumClass x = new PolymorphisumClass();
            x.Test();
            x.Test(10);
            x.Test(5,10);
        }
    }
}
