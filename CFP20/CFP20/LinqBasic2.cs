using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace CFP20
{
    public class LinqBasic2
    {
        public void Test2()
        {
            //element Access
            string[] words = { "falcon", "oak", "sky", "cloud", "tree", "tea", "water" };
            var x = from i in words where i.Length == 3 select i;
            foreach (var i in x)
                Console.WriteLine(i);
            Console.WriteLine("using Lambda");
            var y = words.Where(x => x.Length == 3);
            foreach (var i in y)
                Console.WriteLine(i);
            Console.WriteLine();

            //linq select

            int[] a = { 1, 2, 3, 4, 5 };
            var a1 = from i in a select Math.Pow(i, 2);
            Console.WriteLine("{ " + string.Join(",", a1) + "}");

            var a2 = a.Select(x => Math.Pow(x, 2));
            Console.WriteLine("{ " + string.Join(",", a2) + "}");

            //Linq Concat
            List<string> b = new List<string> { "John", "Doe", "gardener" };
            List<string> b1 = new List<string> { "Jane", "Doe", "teacher" };
            List<string> b2 = new List<string>(b.Concat(b1));
            foreach(var i in b2)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();

            //filter 

            List<string> c = new List<string> { "sky", "rock", "forest", "new",
                "falcon", "jewelry", "small", "eagle", "blue", "gray" };
            var c1 = from i in c where i.StartsWith('f')|| i.StartsWith('s') select i;


            foreach (var i in c1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            var c2 = c.Where(i => i.StartsWith('f') || i.StartsWith('s'));
            foreach (var i in c2)
            {
                Console.WriteLine(i);
            }

            //cartesian product
            char[] letters = "abcdefghi".ToCharArray();
            char[] digits = "123456789".ToCharArray();

            var d=from i in letters from j in digits select new { i, j };
            foreach(var k in d)
                Console.Write($"{k.i},{k.j} ");
            Console.WriteLine();

            //Aggregate calculations
            var e= new List<int> { 6, 2, -3, 4, -5, 9, 7, 8 };
            var e1 = e.Sum();

            var e2 = (from i in e where i > 0 select i).Count();
            Console.WriteLine(e2);


            var e3= e.Average(x=> x);
            Console.WriteLine(e3);

            var e4 = e.Average(); //linq method
            Console.WriteLine(e4);

            var e5= e.Max(x=> x);
            Console.WriteLine(e5);

            var e6= e.Min(x=> x);
            Console.WriteLine(e6);

            var e7 = e.Max();
            Console.WriteLine(e7);

            var e8 = e.Min();
            Console.WriteLine(e8);
            Console.WriteLine();

            //orderby

            int[] f = { 4, 5, 3, 2, 7, 0, 1, 6 };

            var f1= from i in f orderby i select i;
            foreach (var item in f1)
                Console.WriteLine(item);

            var f2 =f.OrderBy(i => i);
            foreach (var item in f2)
                Console.WriteLine(item);
            Console.WriteLine();

            //Reverse()

            int[] g = { 1, 3, 6, 0, -1, 2, 9, 9, 8 };
            var g1=g.Reverse();
            foreach(var item in g)
                Console.WriteLine(item);
            Console.WriteLine();

            //















        }
    }
}
