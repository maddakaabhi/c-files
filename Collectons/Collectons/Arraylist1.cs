// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
public class Arraylist1
{
    static void Main(string[] args)
    {
        ArrayList list = new ArrayList();
        list.Add(1);
        list.Add("Hi");
        list.Add(3.4f);
        list.Add("good");
        
        foreach(object i in list)
            Console.WriteLine(i);

        list.Insert(3, "Welcome");
        Console.WriteLine("\n");
        foreach (object i in list)
            Console.WriteLine(i);
        list.Remove(1);
        list.RemoveAt(3);
        Console.WriteLine("\n");
        foreach (object i in list)
            Console.WriteLine(i);

        Console.ReadLine();


    }
}
