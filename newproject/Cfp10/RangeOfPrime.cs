using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Cfp10
{
    public class RangeOfPrime
    {
        public void prime(int n)
        {
            if (n <= 1)
            {
                Console.WriteLine("There is no prime numbers in this range");
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    int count = 0;
                    for (int j = 2; j < i; j++)
                    {
                        if ((i % j) == 0)
                        {
                            count++;
                            break;
                        }


                    }
                    if (count < 1)
                    {
                        Console.WriteLine(i);
                    }


                }


            }
            // int c = 0;
            //for (int i = 2; i < n; i++)
            // {
            //     if (n%i == 0)
            //     {
            //         c += 1;
            //     }

            // }
            //if( c == 0)
            // {
            //     Console.WriteLine("prime");
            // }
            // else
            // {
            //     Console.WriteLine("Not Prime");
            // }
        }
        static void Main(string[] args)
        {
            RangeOfPrime x = new RangeOfPrime();
            int y=int.Parse(Console.ReadLine());
            x.prime(y);

        }
    }
}