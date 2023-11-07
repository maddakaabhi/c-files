using System;
using System.Collections.Generic;
using System.Text;

namespace CFP4_11review
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int experience {  get; set; }
        public int salary {  get; set; }


    }
    public class TestEmployee
    {
        public void Test1()
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee {Id=101,Name="rahul",experience=3,salary=70000});
            list.Add(new Employee { Id = 101, Name = "rahul", experience = 3, salary = 70000 });
            list.Add(new Employee { Id = 102, Name = "Mahesh", experience = 6, salary = 100000 });
            list.Add(new Employee { Id = 103, Name = "suresh", experience = 7, salary = 120000 });
            list.Add(new Employee { Id = 104, Name = "arjun", experience = 2, salary = 80000 });
            list.Add(new Employee { Id = 105, Name = "shiva", experience = 1, salary = 30000 });

            var x = list.FindAll(x => (x.experience > 5 && x.salary > 60000));
            foreach(var i in x)
                Console.WriteLine(i.Id+" "+i.Name+" "+i.experience+" "+i.salary);
        }
    }
}
