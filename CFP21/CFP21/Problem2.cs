using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CFP21
{
    internal class Problem2
    {
        public void Test()
        {
            List<string> list = new List<string>() { "cat", "dog", "elephant", "tiger" };
            var x = list.Select(x => x.ToUpper()).ToList();
            foreach(var i in x)
                Console.WriteLine(i);
        }

    }
}
