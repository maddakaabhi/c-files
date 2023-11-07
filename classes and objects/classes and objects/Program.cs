using System;
using System.Runtime.CompilerServices;

namespace classes_and_objects
{
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            Console.WriteLine("enter roll no");
            int age = Convert.ToInt32(Console.ReadLine());
            Book ali = new Book(name, age, 25);
            ali.getstudent();
        }
    }

}