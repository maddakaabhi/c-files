using System;
using System.Collections.Generic;
using System.Text;

namespace Cfp10
{
    internal class Palindrome
    {
        string z = null;
        public string palindrome(string s)
        {
            for (int i = s.Length-1; i >=0 ; i--) {
                z += s[i];
               
            }

            if (z == s) 
            {
                return $"string {s} is palindrome";
            
            }
            else
            {
                return $"string {s} is not palindrome";
            }
        }
        static void Main(string[] args)
        {
            Palindrome y = new Palindrome();
            string s=Console.ReadLine();
            Console.WriteLine(y.palindrome(s));
        }
    }
}
