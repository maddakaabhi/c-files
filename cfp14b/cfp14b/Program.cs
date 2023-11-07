using System;

namespace cfp14b
{
    internal class Program
    {
        public int Test(int n)
        {
            if (n == 100) return 100;
            Console.WriteLine(n);
            return Test(n + 1);

        }
        static void Main(string[] args)
        {
            Program a = new Program();
            Console.WriteLine(a.Test(1));
            
        }
    }
}
