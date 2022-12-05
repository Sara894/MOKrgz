using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOKrgz
{
    class NumberAlgo
    {

        public static  Int32 gcd(Int32 x, Int32 y)
        {
            while (y != 0)
            {
                Int32 res = x % y;
                x = y;
                y = res;
            }
            return x;
        }


        public static int[] diof(Int32 a, Int32 b, Int32 c)
        {
            int[] arr = new int[4];
            arr[0] = a;
            arr[1] = b;
           for(int i = -10; i < 10000; i++)
            {
                for(int j = -10; j < 10000; j++)
                {
                    if(a*i + b*j == c)
                    {
                        arr[2] = i;
                        arr[3] = j;
                        goto ret;
                    }
                }
            }
        ret:
            return arr;

        }
    }
}
