using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_Programming
{
    public class Sum
    {
        public static void findTriplets(int[] arr, int n)//initial we take array 
        {
            bool found = true;
            for (int i = 0; i < n - 2; i++)// i start from 0 and less than n-2
            {
                for (int j = i + 1; j < n - 1; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == 0)
                        {
                            Console.Write(arr[i]);
                            Console.Write(" ");
                            Console.Write(arr[j]);
                            Console.Write(" ");
                            Console.Write(arr[k]);
                            Console.Write("\n ");
                            found = true;
                        }
                        if (found == false)
                            Console.Write("not exist");
                    }
                 
                }

            }
        }
        public static void Srm()
        {
            int[] arr = { 0, -1, 2, -3, 1 };
            int n = arr.Length;
            findTriplets(arr, n);


        }



    }
}
