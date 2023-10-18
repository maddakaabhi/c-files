using System;
using System.Collections;
using System.Text;

namespace CFP18
{
    internal class CollectionsArraylist
    {
        public  void Test()
        {
            ArrayList list = new ArrayList();
            list.Add(100);
            list.Add("Hello");
            list.Add(2.3);

            foreach(var i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Inserting");
            list.Insert(1, 20);  //inserting at specified index
            int[] a = { 2, 3, 4 };
            list.InsertRange(2, a);  //inserting  a range of elements at certain index

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Removing");
            list.RemoveAt(0);   //removing element at specified index
            list.Remove(3);
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }



        }
    }
}
