using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CFP21
{
    internal class Person
    {
        public string Name { get; set; }
        public int age { get; set; }
        public string address {  get; set; }
        public void Test1()
        {
            List<Person> list = new List<Person>();
            Person p = new Person { Name = "Ramesh", age = 25, address = "Bangalore" };
            Person p1 = new Person { Name = "Arun", age = 23, address = "Delhi" };
            Person p2 = new Person { Name = "Sai", age = 22, address = "Hyderabad" };
            Person p3= new Person { Name = "Varun", age = 21, address = "Kolkata" };
            Person p4 = new Person { Name = "Mahesh", age = 23, address = "Mumbai" };

            list.Add(p);list.Add(p1);list.Add(p2);list.Add(p3);list.Add(p4);

            var p5=list.OrderBy(x=>x.age);
            foreach(var i in  p5)
                Console.WriteLine(i.Name+" "+i.age+" "+i.address);

            Console.WriteLine();

            var p6=list.OrderBy(x=>x.Name);
            foreach (var i in p6)
                Console.WriteLine(i.Name + " " + i.age + " " + i.address);

            Console.WriteLine();

            var p7=from i in list orderby i.age select i;
            foreach (var i in p7)
                Console.WriteLine(i.Name + " " + i.age + " " + i.address);

            Console.WriteLine();

            var p8 = from i in list orderby i.Name select i;
            foreach (var i in p8)
                Console.WriteLine(i.Name + " " + i.age + " " + i.address);

            Console.WriteLine();




        }
    }
}
