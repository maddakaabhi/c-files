using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acessdemo1
{
    public class Rough1
    {
        public int id;
        public string name;
        public Rough1(int id, string name)
        {
            this.id = id;
            this.name = name;

            Console.WriteLine(id + " " + name);
        }
        public void display()
        {
            Console.WriteLine(id + " " + name);
        }

    }
}
