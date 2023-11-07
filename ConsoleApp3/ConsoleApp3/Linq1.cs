// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

public class Linq1
{
    static void Main(string[] args)
    {
        int[] arr = { 37, 29, 39, 40, 56, 19, 23, 34, 2, 5, 8, 65, 78 };
        var brr=from i in arr where i>30 orderby i select i;   //ascending order sorting
        var crr=from i in arr where i> 30 orderby i descending select i; //descending order

        //foreach( var i in brr)
        //    Console.Write(i+" ");

        //Console.WriteLine();

        //foreach( var i in crr)
        //    Console.Write(i+" ");

        var drr = arr.Where(i => i>30).OrderBy(i=>i);
        foreach (var i in drr)
            Console.Write(i + " ");
    }
}
