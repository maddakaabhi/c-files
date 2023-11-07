// See https://aka.ms/new-console-template for more information
using System;
namespace Delegate1
{
    public delegate void adddelegate(int x, int y);              //creating delegates
    public delegate string helo(string name);
    class Program
    {
       
        public void add(int x, int y)                            //creating methods
        {
            Console.WriteLine(x + y);
        }
        public static string Hello(string name)
        {
            return "hello " + name;
        }
        static void Main(string[] args)
        {
            Program p = new Program();      //creating instances
            p.add(100, 50);                  //calling method through instances
            Console.WriteLine(Hello("abhi"));
           
            Console.WriteLine("\n");

            adddelegate ad = new adddelegate(p.add);  //intiating delegate method 1
            ad.Invoke(100, 50);                       //calling delegate method by invoke and passing parameters
            helo sd = new helo(Hello);               
            Console.WriteLine(sd.Invoke("raju"));
        }
    }
}
