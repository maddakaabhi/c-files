using System;
using System.Collections.Generic;
using System.Text;

namespace Cfp
{
    public class Ex4
    {
        public int id { get; set; }
        public string name {  get; set; }
        public string job {  get; set; }

    }

    public class Encaps
    {
        static void Main(string[] args)
        {
            
            Ex4 p = new Ex4 { id = 10, name = "Abhi", job = "Engineer" } ;
            Console.WriteLine(p.id);
            Console.WriteLine(p.name);
            Console.WriteLine(p.job);
            


        }
    }
}
