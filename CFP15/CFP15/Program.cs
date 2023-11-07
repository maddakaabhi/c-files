using System;

namespace CFP15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Class1.Test(2,2));
            //Console.WriteLine(Class1.Test("Abhi","Abhi"));
            //Console.WriteLine(Class1.Test(2.23,2.23));

            //Class2<int> y = new Class2<int>(5);
            //Console.WriteLine(y.Test2());
            //Class2<string> z = new Class2<string>("Abhi");
            //Console.WriteLine(z.Test2());

            int[] arr = { 1, 2, 3, 4, 5, 3, 4 };
            Practice1 x = new Practice1();
            Console.WriteLine(x.Test3(arr, 4));

        }
    }
}
