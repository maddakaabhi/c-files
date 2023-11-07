using System;
using System.Collections.Generic;
using System.Text;

namespace CFP30review
{
    internal class Problem1
    {
        public void Test1()
        {
            string a = "Ankush";
            //string b=a.ToUpper();
            //string c=b.Replace(b[0], char.ToLower(b[0]));
            //string d= c.Replace(c[c.Length - 1], char.ToLower(c[c.Length-1]));

            //Console.WriteLine(d);
            string d=a.ToUpper();
            char[] b = d.ToCharArray();
            b[0] = char.ToLower(b[0]);
            b[b.Length - 1] = char.ToLower(b[b.Length - 1]);

            string c=new string(b);

            Console.WriteLine(c);


        }
    }
}
