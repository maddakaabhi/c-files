using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collectons
{
    internal class Generics1
    {
        public bool Compare<T>(T a,T b)          //type of data (it acess all kind of data)
        {
            if (a.Equals(b))
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            Generics1 g = new Generics1();
            Console.WriteLine(g.Compare(10, 10));
            Console.WriteLine(g.Compare("Hello","hello"));
        }
    }
}
