using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz.Algorithm
{
    class BinaryString
    {
        static int binarySearch(String[] arr, String x)
        {
            int l = 0, r = arr.Length - 1;
            while (l <= r)
            {
                int m = l + (r - 1) / 2;
                int res = x.CompareTo(arr[m]);
                if (res == 0)
                    return m;
                if (res > 0)
                    l = m + 1;
                else
                {
                    r = m - 1;
                    return -1;
                    static void Main(String[] args)
                    {
                        String[] arr = { "contribute", "geeks", "ide" };
                        String x = "ide";
                        int result = binarySearch(arr, x);
                        if (result == -1)
                            Console.WriteLine("element not present");
                        else
                            Console.WriteLine("element found at" + "index" + result);

                    }
                }
            }
        }
    }
}
