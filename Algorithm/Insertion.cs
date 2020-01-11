using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz.Algorithm
{
    class Insertion
    {
        static void sort(String[] s, int n)
        {
            for (int i = 1; i < n; i++)
            {
                String tenp = s[i];
                //insert s[j]at its correct position
                int j = i - 1;
                while (j >= 0 && temp.Length < s[j].Length)
                {
                    int temp;
                    s[j + 1] = s[j];
                    j--;
                }
                s[j + 1] = temp;
            }
        }
        //function to print the sorted array of string
        static void printArraystring(String[] str, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(str[i] + " ");
        }
        public static void Main()
        {
            String[] arr = { "GreeksforGreeks", "I", "from", "am" };
            int n = arr.Length;
            printArraystring(arr, n);




        }
    }
}

