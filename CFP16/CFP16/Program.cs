using System;

namespace CFP16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Class1 p = new Class1();
            //int[] arr1 = new int[4];
            //p.Test(arr1);
            //string[] arr2 = new string[4];
            //p.Test(arr2);
            //double[] arr3 = new double[4];  
            //p.Test(arr3);

            //Class1G x = new Class1G();
            //int[] arr1 = new int[4];
            //string[] arr2 = new string[4];  
            //double[] arr3 = new double[4];
            //x.Test(arr1);
            //x.Test(arr2);
            //x.Test(arr3);

            //Class2 cl= new Class2();
            //cl.Test();

            //Class2G cl = new Class2G();
            //Console.WriteLine("Maximum number in int variables");
            //int x=3, y=4, z=2;
            //Console.WriteLine(cl.Test1(x, y, z));
            //Console.WriteLine("Maximum number in double variables");
            //double a = 2.4, b = 3.6, c = 5.8;
            //Console.WriteLine(cl.Test1(a, b, c));

            Class1G p = new Class1G();
            int[] arr1 = {2,3,4,5,6};
            p.Test2<int>(arr1);
            Console.WriteLine();
            string[] arr2 = { "hi","Hello","Good"};
            p.Test2<string>(arr2);


        }
    }
}
