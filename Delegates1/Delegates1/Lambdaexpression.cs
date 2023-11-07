using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1
{
    public delegate void Delegates1(string name);
    public class Lambdaexpression
    {
            static void Main(String[] args)
            {
                Delegates1 x = (y) =>              //Lambda expression to minimise the anonymus.cs
                {
                    Console.WriteLine("hello " + y);
                };
                x.Invoke("Abhi");
            }
        }
 }