using System;
namespace Cfp10
{
   public class Fibonacci
    {
        int x = 0, y = 1;
        public void fibonacci(int n)
        {
            Console.Write(x + " " + y + " ");
            for (int i = 0; i < n; i++)
            {
                int temp=y;
                y=x+y;
                x=temp;
                Console.Write(y+ " ");
            }

        }
        static void Main(string[] args)
        {
            Fibonacci fib=new Fibonacci();
            int z=int.Parse(Console.ReadLine());
            fib.fibonacci(z);
        }
    }
}