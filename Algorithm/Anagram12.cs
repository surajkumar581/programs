using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz.Algorithm
{
    class Anagram12 { 
    public static void Main()
        {
            string str1 = "heater";
            string str2 = "reheat";
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);
            if (val1 == val2)
            {
                Console.WriteLine("both are equal");
            }
            else {
                Console.WriteLine("both are not equal");


        }

    }



}
}
