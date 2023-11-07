using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collectons
{
    internal class Dictionary1
    {
        static void Main(string[] args)
        {
            Dictionary <string,Object> dic1 = new Dictionary<string,Object>(); //replacement of hashtable
            dic1.Add("101", 101);
            dic1.Add("name", "Abhi");
            dic1.Add("job", "Manager");

            foreach(string key in dic1.Keys)
            {
                Console.WriteLine(key + "=" + dic1[key]);
            }

        }
    }
}
