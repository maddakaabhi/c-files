using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties1
{
    public class TestCustomer
    {
        static void Main(string[] args)
        {
            Customer obj = new Customer(101, false, "john", 5000.0,Cities.bengaluru);
            Console.WriteLine(obj.custid);   //it is only gettable
            Console.WriteLine(obj.status);   //it is both both get and settable
            if (obj.status == true)
                Console.WriteLine("Active");
            else
                Console.WriteLine("in-active");
            Console.WriteLine("Current balance :"+ obj.balance);
            obj.balance -= 3000; //assignment failed due to status false
            Console.WriteLine("modified balance :"+ obj.balance);
            Console.WriteLine("old city :" + obj.city);
            obj.city = Cities.Hyderabad;
            Console.WriteLine("new city :" + obj.city);
            obj.status = true;
            if (obj.status == true)
                Console.WriteLine("Active");
            else
                Console.WriteLine("in-active");
            Console.WriteLine("Current balance :" + obj.balance);
            obj.balance -= 3000;  //assignment is success due to status is true
            Console.WriteLine("modified balance :" + obj.balance);
            Console.WriteLine("old city :"+obj.city);
            obj.city = Cities.Hyderabad;
            Console.WriteLine("new city :" + obj.city);
        }
    }
}
