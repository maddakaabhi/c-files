using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance2
{
    public class Class1
    {
        string Name;
        int no;

        public Class1(string Name, int no)
        {
            this.Name = Name;
            this.no = no;
            Console.WriteLine(Name + " " + no);
        }

        public void Hello(string Name)
        {
            Console.WriteLine(Name);
        }
    }

   

}