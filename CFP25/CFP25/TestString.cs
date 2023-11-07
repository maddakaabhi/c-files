using System;
using System.Collections.Generic;
using System.Text;

namespace CFP25
{
    public class TestString
    {
        public string Test1(string s)
        {
            try
            {
                if (s == null)
                {
                    throw new ArgumentNullException();
                }
                return s;

            }
            catch (ArgumentNullException  e)
            {
                return e.Message;
            }
            
        }
    }
}
