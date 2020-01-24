using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_Programming
{
    class Glamber
    {
        public static  void IsGambler()
        {
            Console.WriteLine("enter the noof stack");
            int stack = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the noof goal");
            int goal = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the noof trial");
            int trial = int.Parse(Console.ReadLine());
            int bets = 0;
            int wins = 0;

            for (int t = 0; t < trial; t++)
            {
                int cash = stack;
                while (cash > 0 && cash < goal)
                {
                    bets++;
                    Random random = new Random();
                    if (random.Next() < 0.5)
                    {
                        cash++;
                    }
                }
                if (cash == goal)
                    wins++;
            }
            Console.WriteLine(wins + "wins of" + trial);
            Console.WriteLine("percentage of game winner " + 100 * wins / trial);
            Console.WriteLine("average of bets" + 1.0 * bets / trial);

        }
    }
}

