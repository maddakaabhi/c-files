using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Text;

namespace cfp14b
{
    public class Class1
    {
        public void Test(string a)
        {
            bool b =a.Contains('a');
            bool c =a.Contains('e');
            bool d = a.Contains('p');

            if (b && c && d) { Console.WriteLine("All are present"); }
            else if (b ||  c || d) { Console.WriteLine("one or more present"); }
            else { Console.WriteLine("none is present"); }
        }
    
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string a = Console.ReadLine();
            Class1 b = new Class1();
            b.Test(a);

        }
    }
}
