using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz.Algorithm
{
    class Linears


    {
        public static int Search()
        {
            int[] arr = { 2, 3, 4, 5, 10 };
            int x = 10;
            int result = search(arr, x);
            if (result == -1)
            {
                Console.WriteLine("element is not present");
                else
                    Console.WriteLine("element is present");
                int n = arr.Length;
                for (int i = 0; i < n; i++)
                {
                    if (arr[i] == x)
                        return i;
                }
               
            }



        } }
}






