using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace classes_and_objects
{
    public class Book
    {
       string name;
       int age;
       int pages;
        public Book(string name, int age, int pages)
        {
            this.name = name;
            this.age = age;
            this.pages = pages;
        }
        public void getstudent()
        {
            Console.WriteLine("the name of the person" + this.name);
            Console.WriteLine("The age of the person" + this.age);
            Console.WriteLine("no of pages" + this.pages);
        }
        

    }

}
