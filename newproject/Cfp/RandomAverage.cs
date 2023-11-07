using System;
using System.Collections.Generic;
using System.Text;

namespace Cfp
{
    internal class RandomAverage

    {
        int sum = 0;
        Random rnd = new Random();
        public void Average(int n)
        {
            
            for (int i = 0; i < n; i++)
            {
                
                int x= rnd.Next(10,99);
                Console.WriteLine(x);
                sum += x;
            }
            Console.WriteLine(sum/n);

        }
        static void Main(string[] args)
        { 
            RandomAverage y = new RandomAverage ();
            int n=Convert.ToInt32(Console.ReadLine());
            y.Average (n);


        }

    }
    
}
