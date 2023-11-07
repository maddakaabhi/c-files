using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance2
{
    public class Class5 : Class4
    {
        
        public Class5(int a) : base(a)            //assigning value to parent class thrugh constructor
        {
            Console.WriteLine("Class 5  constructor is called " + a);
        }
        static void Main(string[] args)
        {
            int z= Convert.ToInt32(Console.ReadLine());
            Class5 y= new Class5(z); 
        }

    }
}
