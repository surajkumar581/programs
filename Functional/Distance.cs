using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_Programming
{
    class Distance
    {
        public static void Bw()
        {
            Console.WriteLine("enter the value of x");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the value of y");
            int y = Convert.ToInt32(Console.ReadLine());
            double dist = Math.Sqrt(x * x + y * y);
            Console.WriteLine("distance(" + x + "," + y + ")to(0,0)=" + dist);
        }

    }
}

