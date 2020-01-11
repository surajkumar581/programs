using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz.Algorithm
{
    class Bubble_sort
    {
        static void Main(string[] args)
        {

            int[] array = { 98, 2, 8, 4, 5, 34, 7, 8, 9 };
            int temp = 0;
            for (int i = 0; i <= array.Length; i++)
            {// i start from 0 and less than array.length
                for (int j = i + 1; j <= array.Length - 1; j++)
                {
                    if (array[i] > array[j])
                    {// comparison of two no in the array list

                         temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                    for (int k = 0; i <= array.Length; i++)
                    {
                        Console.WriteLine("array[i]" + i);
                    }
                }
            }
        }
    }
}







        
                 
          
