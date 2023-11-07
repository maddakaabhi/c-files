using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CFP20
{
    public class Patient
    {
        public string name {  get; set; }
        public string Gender { get; set; }
        public int Age {  get; set; }
        public string Area {  get; set; }
    }

    public class TestPatient
    {
        public void Test1()
        {
            List<Patient> list = new List<Patient>();  //creating a empty list
            Patient p = new Patient { name="A",Gender="M",Age=24,Area="BTM"};                 // creating Instance of a class and passing values to fields
            Patient q = new Patient { name = "B", Gender = "F", Age = 23, Area = "HSR" };
            Patient r = new Patient { name = "C", Gender = "M", Age = 25, Area = "HSR" };
            Patient s = new Patient { name = "D", Gender = "F", Age = 21, Area = "BTM" };

            list.Add(p);list.Add(q);list.Add(r);list.Add(s);

            var x= from i in list select i;
            foreach(var y in x)
                Console.WriteLine(y.name+" "+y.Gender+" "+y.Age+" "+y.Area);

            var z = (from i in list select i).Count();
            Console.WriteLine("No of records in List "+z);
            Console.WriteLine();
            var a = from i in list where i.Age < 25 orderby i.Age select i;
            foreach (var y in a)
                Console.WriteLine(y.name + " " + y.Gender + " " + y.Age + " " + y.Area);

            Console.WriteLine();
            Console.WriteLine("using Lambda");
            var b= list.FindAll(x => x.Age<25);
            var c = b.OrderBy(i => i.Age);
            foreach (var y in c) 
                    Console.WriteLine(y.name + " " + y.Gender + " " + y.Age + " " + y.Area);






        }

    }
}
