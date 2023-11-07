using System;
using System.Collections.Generic;

class Genericcollection
{
    static void Main(string[] args)
    {
        List<int> li = new List<int>();
        li.Add(10);
        li.Add(20);
        li.Add(30);

        for (int i = 0; i < li.Count; i++) {
            Console.WriteLine(li[i]);
        }
    }
}
