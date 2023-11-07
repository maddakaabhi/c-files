using System;
using System.Collections;
using System.Text;

namespace CFP18
{
    public class CollectionSorted
    {
        public void Test4()
        {
            SortedList x = new SortedList();
            x.Add(2, "two");
            x.Add(4, "four");
            x.Add(1, "one");
            x.Add(3, "three");

            foreach (DictionaryEntry kvp in x)
                Console.WriteLine("Key:{0}, Value:{1}", kvp.Key, kvp.Value);
            Console.WriteLine();

            Console.WriteLine("updating a value");
            x[1] = "One";
            foreach (DictionaryEntry kvp in x)
                Console.WriteLine("Key:{0}, Value:{1}", kvp.Key, kvp.Value);
            Console.WriteLine();
            Console.WriteLine("Removing an element-- key=3");
            x.Remove(3);
            Console.WriteLine();
            Console.WriteLine("After removing an element");
            foreach (DictionaryEntry y in x)
            {
                Console.WriteLine(y.Key + " = " +y.Value);
            }
            Console.WriteLine();




        }
    }
}
