using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collectons
{
    class TestUserdefined
    {
        static void Main(string[] args)
        {
            List<Userdefined> li = new List<Userdefined>();
            Userdefined x = new Userdefined { Id = 101, Name = "Hello", City = "Bangalore", balance = 25000.00 };
            Userdefined y = new Userdefined { Id = 103, Name = "Hi", City = "Hyderabad", balance = 29000.00 };
            Userdefined z = new Userdefined { Id = 102, Name = "good", City = "delhi", balance = 30000.00 };
            li.Add(x);li.Add(y);li.Add(z);

            foreach (Userdefined i in li)
            {
                Console.WriteLine(i.Id +" "+i.Name+" "+i.City+" "+i.balance);
            }
        }
    }
}
