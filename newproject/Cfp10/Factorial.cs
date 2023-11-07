using System;

namespace Cfp10
{
    internal class Factorial
    {
        int fact = 1;

        public void factorial(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                fact *= i;


            }
            Console.WriteLine($"Factorial of {n} is " + fact);


            Console.WriteLine("--------------");

        }
        static void Main(string[] args)
        {
            Factorial x = new Factorial();
            int n=int.Parse(Console.ReadLine());
            x.factorial(n);
            
        }
    }
}
