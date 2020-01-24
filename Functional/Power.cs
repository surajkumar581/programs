using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_Programming
{
    class Power
    {
        static bool isPowerofTwo(int n)
        {
            if (n == 0)//
                return false;

            while (n != 1)//until n!=1 it is running

            {
                if (n % 2 != 0)//if n !=0 then return false
                    return false;
                n = n / 2;
            }
            return true;
        }
       public static  void Power12()
        {
            Console.WriteLine(isPowerofTwo(31) ? "Yes" : "No");
            Console.WriteLine(isPowerofTwo(64) ? "Yes" : "No");

        }
    }
}