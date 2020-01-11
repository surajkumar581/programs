using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz.Algorithm
{
    class Merge
    {
        static void Main(string[] args)
        {
            List<int> unsorted = new List<int>();
            List<int> sorted;
            Random random = new Random();
            Console.WriteLine("original array element:");
            for (int i = 0; i < 10; i++)
            {
                unsorted.Add(random.Next(0, 100));
                Console.Write(unsorted[i] + " ");
            }
            Console.WriteLine();
            sorted = MergeSort(unsorted);
            Console.WriteLine("sorted array element:");
            foreach (int X in sorted)
            {
                Console.Write(X + "");
            }
            Console.Write("\n");
        }
        private static List<int> MergeSort(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
                return unsorted;
            List<int> left = new List<int>();
            List<int> right = new List<int>();
            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)// dividing the unsorted list
            {
                left.Add(unsorted[i]);
            }
            right.Add(unsorted[i]);
        }
        left=MergeSort(left);
        right=MergeSort(right);
        return Merge(left, right);
    }
    private static List<int> Merge(List<int> left, List<int> right) {
        List<int> right = new List<int>();
        while (left.Count > 0 || right.Count > 0)
        {
            if (left.Count > 0 && right.Count > 0)
            {
                if (left.First() <= right())
                {
                    Result.Add(right.First());
                    right.Remove(right.First());
                }
            }
            else if (right.Count > 0)
            {
                Result.Add(right.First());
                right.Add(right.First());
            }
        }
        return result;
    }




    

                
                
                
                
        
    }
}
