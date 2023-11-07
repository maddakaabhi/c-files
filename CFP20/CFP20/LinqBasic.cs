using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;
using System.Threading;

namespace CFP20
{
    public class LinqBasic
    {
        public void Test()
        {
            Console.WriteLine("ex1");
            List<int> a = new List<int>(){ 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            var numbers = from x in a where x>8 select x;
           foreach (var number in numbers)
                Console.WriteLine(number);

            Console.WriteLine("using lambda");
            var b = a.FindAll(c => c > 8);
            foreach(var i in b)
                Console.WriteLine(i);

            Console.WriteLine();
            Console.WriteLine("ex2");
            int[] y = { 5, 4, 1, 3, 9, 8 };
            var numsPlusOne = from n in y select n;
            foreach (var i in numsPlusOne)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("using lambda");
            var ex1 = y.Select(x => x);
            foreach (var i in ex1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine("ex3");

            int[] ex3 = { 4, 5, 6, 7, 3, 5 };
            var ex31a = (from i in ex3 select i).Count();
            Console.WriteLine(ex31a);
            Console.WriteLine("using Lambda");
            var ex31= ex3.Count();
            Console.WriteLine(ex31);

            Console.WriteLine();
            Console.WriteLine("ex4");

            int[] numb = { 4, 3, 2, 8, 7, 6, 9 };
            Console.WriteLine("Counting no of even number elements in list");
            var e = (from i in numb where i % 2 == 0 select i).Count();
            Console.WriteLine(e);
            var e1 = from i in numb where i % 2 == 0 select i;
            foreach (var i in e1)
                Console.WriteLine(i);


            Console.WriteLine("using LAmbda");
            var d=numb.Count(x => x %2==0);
            Console.WriteLine(d);
            var d1 = numb.Where(x => x % 2 == 0);
            foreach (var i in d1)
                Console.WriteLine(i);















        }

    }
}
