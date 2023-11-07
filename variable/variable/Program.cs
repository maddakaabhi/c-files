// See https://aka.ms/new-console-template for more information
using System;
namespace variable
{
    class program
    {
        int y=200;    //non static 
        static int x=100;  //static
        const float pi = 3.14f;
        readonly bool flag;

        public program(int z)
        {
            this.y = z;
            this.flag = true;

        }                         
        static void Main(string[] args)
        {
            x = 400;
            Console.WriteLine(x);   //we can directly print the value of x
            program p=new program(50);    //for calling non static variable we need to create instance
            Console.WriteLine(p.y);
            p.y = 300;                     //non static variable are modified after intiliazation through a constructor
            Console.WriteLine(p.y);
        }
    }
}
