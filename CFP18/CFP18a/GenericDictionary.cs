using System;
using System.Collections.Generic;
using System.Text;

namespace CFP18a
{
    internal class GenericDictionary
    {
        public void Test4()
        {
            Dictionary<int,string> dic = new Dictionary<int,string>();
            dic.Add(3, "Abhi");
            dic.Add(2, 1);
            dic.Add(5, "engineer");

            foreach (var key in dic.Keys)
            {
                Console.WriteLine(key + " = " + dic[key]);
            }
            Console.WriteLine();

            Console.WriteLine("Removing an element--");

            dic.Remove(2);
            foreach (var key in dic.Keys)
            {
                Console.WriteLine(key + " = " + dic[key]);
            }
            Console.WriteLine();
            dic[6] = "Bangalore";
            foreach (var key in dic.Keys)
            {
                Console.WriteLine(key + " = " + dic[key]);
            }
            Console.WriteLine();

            //updating value
            if (dic.ContainsKey(8))
            {
                dic[8] = "Hyderabad";
            }
            foreach (var key in dic.Keys)
            {
                Console.WriteLine(key + " = " + dic[key]);
            }


        }
    }
}
