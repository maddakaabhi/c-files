using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acessdemo1
{
    public class Rough2 : Rough1
    {
        string name;
        int id;
        public Rough2(string name,int id):base(id,name) {
            this.name = name;
            this.id = id;

            Console.WriteLine(name + " " + id);
        }
        public static void Main(string[] args)
        {
            Rough2 x = new Rough2("Abhi", 8);
            x.display();

            Console.WriteLine("child class ended");
            Rough1 y = new Rough1(8, "Abhi");
            y.display();
        }


    }
}
