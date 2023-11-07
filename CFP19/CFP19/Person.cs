using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CFP19
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
    }

    public class TestPerson
    {
        public void Test2()
        {
            List<Person> list = new List<Person>();

            Person p1 = new Person { Id =101,Name="A",Address="Bangalore",Age=24};
            Person p2 = new Person { Id = 103, Name = "b", Address = "Delhi", Age = 14 };
            Person p3 = new Person { Id = 102, Name = "e", Address = "Hyderabad", Age = 16 };
            Person p4 = new Person { Id = 100, Name = "d", Address = "Mumbai", Age = 17 };
            Person p5 = new Person { Id = 105, Name = "m", Address = "Kolkata", Age = 50 };
            Person p6 = new Person { Id = 107, Name = "l", Address = "pune", Age = 52 };
            list.Add(p1);list.Add(p2);list.Add(p3);list.Add(p4);list.Add(p5);list.Add(p6);
            
            //uc2
            var numbers= list.OrderByDescending(x=>x.Age);

            var x  = numbers.Take(2);

            foreach (var i in x)
                Console.WriteLine(i.Id+" "+i.Name+" "+i.Address+" "+i.Age);

            Console.WriteLine();
            //uc3
            var y = list.FindAll(x =>( x.Age >= 13 && x.Age < 18 ));
            foreach (var i in y)
                Console.WriteLine(i.Id + " " + i.Name + " " + i.Address + " " + i.Age);
            Console.WriteLine();
            //uc4
            var z =list.Average(x=> x.Age);
            Console.WriteLine(Math.Round(z,1));
            Console.WriteLine();

            var a = list.Max(x => x.Age);
            Console.WriteLine(a);
            Console.WriteLine();

            var b = list.Min(x => x.Age);
            Console.WriteLine(b);




            //var item = list.Select(x=>new { Id = x.Id, Name = x.Name });
            //foreach (var i in item)
            //    Console.WriteLine(i);

            //Console.WriteLine();

            //Console.WriteLine("sorting");
            //var item1 = list.OrderBy(x=>x.Age);
            //foreach (var i in item1) Console.WriteLine($"{i.Name} is {i.Age} years old");




        }

    }
}
