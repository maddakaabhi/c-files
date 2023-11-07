using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collectons
{
    public class Hashtable1
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("eid", 1010);
            ht.Add("job", "Manager");
            ht.Add("mgrid", 1002);
            ht.Add("name", "Scott");

            foreach(object keys in ht.Keys)
                Console.WriteLine(keys + "=" + ht[keys]);

            Console.WriteLine(ht["job"]);

        }
    }
}
