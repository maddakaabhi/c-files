
using CFP2_11;
using System;
using System.Collections.Generic;

namespace CFP2_11Ado.NET

{
    public class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository x = new EmployeeRepository();
            x.createdatabase();
            //List<EmployeeModel> y = x.createdatabase();
            //foreach (EmployeeModel emp in y)
            //{
            //    Console.WriteLine(emp);
            //}
        }
    }
}
