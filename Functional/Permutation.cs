using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_Programming
{
    class Permutation
    {
        private static void permute(String str, int l, int r)
        {
            if (l == r)
                Console.WriteLine(str);
            else
            {
                for (int i = 1; i <= r; i++)// i start from but les than r;

                {
                    str = swap(str, l, i);
                    permute(str, l + 1, r);

                    str = swap(str, l, i);
                }
            }
        }
        public static String swap(String a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string S = new string(charArray);
            return S;
        }






    }
}
