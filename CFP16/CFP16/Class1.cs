using System;
using System.Collections.Generic;
using System.Text;

namespace CFP16
{
    internal class Class1
    {
        public void Test(int[] arr)
        {
            Console.WriteLine("enter elements into int array");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elements in arr int type");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
        public void Test(string[] arr)
        {
            Console.WriteLine("enter elements into string array");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine();
            }
            Console.WriteLine("Elements in arr string type");
            foreach (string i in arr)
            {
                Console.WriteLine(i);
            }
        }
        public void Test(double[] arr)
        {
            Console.WriteLine("enter elements into double array");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Elements in arr double type");
            foreach (double i in arr)
            {
                Console.WriteLine(i);
            }
        }




    }
}
