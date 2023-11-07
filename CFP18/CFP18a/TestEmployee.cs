using System;
using System.Collections.Generic;

using System.Text;

namespace CFP18a
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string role { get; set; }


    }
    public class TestEmployee
    {
        public void Test2()
        {
            List<Employee> list = new List<Employee>();
            Employee emp1 = new Employee { id = 2, name = "a", age = 25, role = "engineer" };
            Employee emp2 = new Employee { id = 1, name = "b", age = 24, role = "Teacher" };
            Employee emp3 = new Employee { id = 3, name = "c", age = 23, role = "lawyer" };
            list.Add(emp1);
            list.Add(emp2);
            list.Add(emp3);

            foreach (Employee emp in list)
            {
                Console.WriteLine(emp1.id + " " + emp.name + " " + emp.age + " " + emp.role);
            }
            Console.WriteLine();



        }
    }
}
    

    

