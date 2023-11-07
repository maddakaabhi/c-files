using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cfp14b
{
    internal class Marray
    {
        //static void MaxDiagonal(int[,] arr)
        //{
        //    int[] b = new int[arr.GetLength(0)];
        //    for (int i = 0; i < arr.GetLength(0); i++)
        //    {
        //        b[i] = arr[i,i];
        //    }
        //    Console.WriteLine(b.Max());


        //}
        static void Main(string[] args)
        {
            //    int[,] a = new int[3,3];
            //    Console.WriteLine("enter array elements");
            //    for (int i = 0; i < a.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < a.GetLength(1); j++)
            //        {
            //            a[i,j] = Convert.ToInt32(Console.ReadLine());
            //        }
            //    }
            //    MaxDiagonal(a);

            int[][] a = new int[2][];
            a[0]= new[] { 11,22,33,44,55,};
            a[1] = new[] { 22, 44, 66, 77, 88, 99, 100 }; 

            foreach (int[] c in a)
            {
                foreach (int d in c)
                {
                    Console.Write(d + " ");

                }
                Console.WriteLine();
                
            }
            



        }
    }
}
