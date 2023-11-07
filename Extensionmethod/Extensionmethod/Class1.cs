using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensionmethod
{
    static class Class1
    {
        public static void Test3(this Program p) //adding this method to Source code as an extension
        {
            Console.WriteLine("Method 3");
        }

        public static long Factorial(this Int32 i)  //creating extension method for struct like int
        {
            if (i == 0)
            {
                return 1;
            }
            if (i == 2) {
                return 2;
            }
            else 
                return i*Factorial(i-1);
        }

        public static string ToProper(this string old)          //creating an extension method to string sealed class
        {
            if (old.Trim().Length > 0)
            {
                string new1 = null;
                old = old.ToLower();
                string[] sarr= old.Split(' ');
                foreach (string s in sarr)
                {
                    char[] carr= s.ToCharArray();
                    carr[0] = Char.ToUpper(carr[0]);
                    if (new1 == null)
                    {
                        new1 = new string(carr);
                    }
                    else
                    {
                        new1 +=" "+ new string(carr);
                    }
                  
                }
                return new1;
             


            }
            return old;

        }
    }
}
