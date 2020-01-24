using System;
using System.Collections.Generic;
using System.Text;


namespace Functional_Programming
{
    class HarmonicNumber
    {
        public static void Har()
        {

            float harmonic = 1;// harmonic is start from 1;
            for (int i = 2; i <= 8; i++)// i is start from 2;
            {
                harmonic += (float)1 / i;// is num 1/2;


            }
            Console.WriteLine(harmonic);
        }
    }
}
