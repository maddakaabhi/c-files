using System;
using System.Collections.Generic;
using System.Text;

namespace CFP26
{
    public class OddNumException : Exception
    {
        public override string Message
        {
            get { return "There cannot be odd divisor"; }
        }
    }
    public class Check : OddNumException
    {
        public void Test1(int i, int j) { 
            try
            {
                if (j % 2 > 0)
                {
                    throw new OddNumException();
                }
                else
                {
                    int c = i / j;
                    Console.WriteLine(c);
                }

            }
            catch (OddNumException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
