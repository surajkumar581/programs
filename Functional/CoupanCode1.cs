using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_Programming
{
    class CoupanCode1
    {
        public static void Mt()
        {
            var chars = "skfnkvfjvvkvvkvNKVVKMBVM012";
            var stringChars = new char[6];
            Random random = new Random();
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
                var finalString = new String(stringChars);







            }
        }
    }
}
