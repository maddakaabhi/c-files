using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance2
{
    public class Class2 : Class1
    {
        int number;
        string name;
        double x;

        public Class2(int number, string Name, double x) : base(Name, number) // Corrected order of parameters
        {
            this.number = number;
            this.name = Name;
            this.x = x;

            Console.WriteLine(number +" "+ name+" "+x );
        }

        static void Main(string[] args)
        {
            Class2 c = new Class2(123, "Abhi",20.03);
            
        }
    }
}
