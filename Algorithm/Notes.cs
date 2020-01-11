using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz.Algorithm


{
    class Notes {
        public static void countCurrency(int amount)
        {
            int[] notes = new int[] { 1, 2, 5, 10, 50, 100, 500, 1000 };
            int[] noteCounter = new int[8];
            for (int i = 0; i < 8; i++)//count notes using greedy approach
            {
                
                if (amount >= notes[i])
                {
                    noteCounter[i] = amount / notes[i];
                    amount = amount - noteCounter[i] * notes[i];
                }
            }
            Console.WriteLine("Currency Count->");
            for (int i = 0; i < 8; i++)
            {
                if (noteCounter[i] != 0)
                {
                    Console.WriteLine(notes[i] + " :" + noteCounter[i]);
                }
            }
        }
        public static void Main()
        {
            int amount = 868;
            countCurrency(amount);
        }
    }
                }




    

    






