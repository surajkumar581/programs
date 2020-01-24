using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_Programming
{
    class Flipcoin
    {
        public static void IsCoin()
        {
            Console.WriteLine("enter number of turns");
            int max = Convert.ToInt32(Console.ReadLine());
            int head = 0; int tail = 0;
            Random rand = new Random();
            int r = rand.Next(max);
            for (int i = 0; i < max; i++)
            {
                 r = rand.Next(max);
                if (r < 0.5)
                {
                    tail++;
                }
                else
                {
                    head++;
                }

            }
            int prh = (head * 100) / max;
            int prt = (tail * 100) / max;
            Console.WriteLine("percentage of head(0)", prh);
            Console.WriteLine("percentage of tail(0)", prt);

        }
    }
}



    

