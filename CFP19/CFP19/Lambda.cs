﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CFP19
{
    public class Lambda
    {
        public void Test1()
        {
            List<int> x =new List<int>() { 1,2,3,4,5,6,7,8,9};
            //var numbers = x.FindAll(x => x%2==0 );

            //foreach(int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}
            x.Reverse();
            foreach(int i in x)
                Console.WriteLine(i);

        }
    }
    
}
