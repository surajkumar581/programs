using System;
using System.Collections.Generic;
using System.Text;


namespace BridgeLabz.Algorithm
{
    class Prime1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("prime number is:\n");
            for (int i = 1; i <= 1000; i++)
            {
                int count = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine(" " + i);
                }
            }
        }
    }
}
