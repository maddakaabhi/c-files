using System;
using System.Collections.Generic;
using System.Text;

namespace Cfp10
{
    public class Armstrong
    {
        int s = 0;
        public void armstrong(int n) 
        
        {
            int t = n;
            while (n > 0)
            {
                int x = n % 10;
                s = s + (int)Math.Pow(x,3);
                n /= 10;
            }

            if (s == t)
            {
                Console.WriteLine($"{t} is an Armstrong number");
            }
            else
            {
                Console.WriteLine($"{t} is not an Armstrong number");
            }
        
        }
        static void Main(string[] args)
        {
            Armstrong a= new Armstrong();
            int n = int.Parse(Console.ReadLine());
            a.armstrong(n);
        }
    }
}
