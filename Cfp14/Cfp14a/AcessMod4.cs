using Cfp14;
using System;

namespace Cfp14a
{
    public class AcessMod4:Cfp14.AcessMod1   //another project child class by inheriting 
    {
        static void Main(string[] args)
        {
            AcessMod4 b = new AcessMod4();
            b.Test2();
            b.Test4();
            b.Test5();
        }
    }
}
