using System;
using System.Collections.Generic;
using System.Text;

namespace Cfp13
{
    public class InheritanceClass:Inheritence
    {
        static void Main(string[] args)
        {
            InheritanceClass x = new InheritanceClass();

            Console.WriteLine(x.s);     //print the value of variable in parent class
            x.s = "good morning";   //assigning new  value to parent class variable
            x.Greet(x.s);        //consuming the method of parentclass


        }
    }
}
