using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace FunctionalProgramming
{
    class StopWatch
    {
        public static void Stop()
        { 
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i <= 1000; i++)
            {
                Thread.Sleep(1);
            }
            ////stop timing
            stopwatch.Stop();

            Console.WriteLine("Time elapsed:(0),stopwatch.Elapsed");

        }
    }
}












            

        



            
     
