using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CFP15
{
    internal class Practice1
    {
        public int Test3(int[] arr,int target)
        {
            for (int i = arr.Length-1; i >=0; i--) 
            {
                if (arr[i] == target)
                {
                    return i;
                    break;
                }
            }
            return -1;
            
        }
    }
}
