using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_Programming
{
    class VendingSwap1
    {
        static int i = 0;
        static int total = 0;
        static int[] notes = { 1000, 500, 100, 50, 5, 2, 1 };
        static int money = int.Parse(Console.ReadLine());

        public static int Calculate()
        {
            int rem;
            if (money == 0)
            {
                return total;
            }
            else
            {
                if (money >= notes[i])
                {
                    int calNotes = money / notes[i];
                    rem = money % notes[i];
                    money = rem;
                    total += calNotes;
                    Console.WriteLine(notes[i] + "Notes" + calNotes);
                }
                i++;
                return Calculate();
            }
        }
    }
}



            
       
            

          


             