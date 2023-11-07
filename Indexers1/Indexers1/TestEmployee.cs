using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers1
{
    public class TestEmployee
    {
        static void Main(string[] args)
        {
            Employee x = new Employee(101, 5000, "john", "son", "karnataka");
            Console.WriteLine(x[0]);
            Console.WriteLine(x[1]);
            Console.WriteLine(x[2]);
            Console.WriteLine(x[3]);
            Console.WriteLine(x[4]);
            Console.WriteLine(x[5]);
        }
    }
}
