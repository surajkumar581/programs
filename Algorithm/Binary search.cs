using System;
using System.Collections.Generic;
using System.Text;
s
namespace BridgeLabz.Algorithm
{
    class Binary_search
    {
        public static object BinarySearchDisplay(int[] arr, int key)
        {
            int minNum = 0;
            int maxNum = arr.length - 1;
            while (minNum <= maxNum)
            {
                int mid = (minNum + maxNum) / 2;
                if (key == arr[mid])
                {
                    return ++mid;
                }
                else if (key < arr[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    minNum = mid + 1;


                }
            }
            return "None";

        }
    }
}






    }
}
