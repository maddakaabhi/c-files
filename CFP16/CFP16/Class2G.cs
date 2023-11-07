using System;
using System.Collections.Generic;
using System.Text;

namespace CFP16
{
    internal class Class2G
    {
        
        public T Test1<T>(T x,T y,T z) where T: IComparable<T>
        {
            if (x.CompareTo(y)>0 && x.CompareTo(z)>0) { return x; }
            else if (y.CompareTo(z) > 0) { return y; }                 
            else { return z; }


        }
    }
}
