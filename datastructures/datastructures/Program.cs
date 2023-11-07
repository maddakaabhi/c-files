// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main() {
        int[] arr = new int[10];
        Console.WriteLine(arr.Length);
        //adding elements into array
        for (int i = 0; i < arr.Length - 1; i++)
        {
            arr[i] = i + 1;
        }

        //foreach (int i in arr)
        //    Console.WriteLine(i);

        //Console.ReadLine();

        ////inserting element in the start
        ////shift elements one by one

        for (int i = arr.Length - 2; i >= 0; i--)
        {
            arr[i + 1] = arr[i];
        }
        

        arr[0] = 20;
        foreach (int i in arr)
            Console.WriteLine(i);
        Console.ReadLine();

        ////inserting elements anywhere like at position 2

        //for (int i = arr.Length - 2; i >= 2; i++)
        //{
        //    arr[i + 1] = arr[i];
        //}
        //foreach (int i in arr)
        //    Console.WriteLine(i);

        //arr[2] = 30;
        //Console.ReadLine();



    }
}


