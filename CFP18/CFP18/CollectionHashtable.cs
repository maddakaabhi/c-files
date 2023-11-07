using System;
using System.Collections;
using System.Text;

namespace CFP18
{
    internal class CollectionsHashtable
    {
        public void Test1() {
            Hashtable ht = new Hashtable();
            ht.Add("name", "Abhi");
            ht.Add("Rollno", 1);
            ht.Add("job", "engineer");

            foreach(var key in ht.Keys)
            {
                Console.WriteLine( key +" = " + ht[key]);
            }
            Console.WriteLine();

            Console.WriteLine("Removing an element--");
            
            ht.Remove("Rollno");
            foreach (var key in ht.Keys)
            {
                Console.WriteLine(key + " = " + ht[key]);
            }
            Console.WriteLine();
            ht["city"]= "Bangalore";
            foreach (var key in ht.Keys)
            {
                Console.WriteLine(key + " = " + ht[key]);
            }
            Console.WriteLine();

            //updating value
            if (ht.ContainsKey("city"))
            {
                ht["city"] = "Hyderabad";
            }
            foreach (var key in ht.Keys)
            {
                Console.WriteLine(key + " = " + ht[key]);
            }


        }

    }
}
