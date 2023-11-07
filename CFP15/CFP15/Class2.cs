using System;
using System.Collections.Generic;
using System.Text;

namespace CFP15
{
    internal class Class2<T>
    {
        T x;
        public Class2(T x) { this.x = x;}

        public T Test2() {  return x;  }

    }
}
