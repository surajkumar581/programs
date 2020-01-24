using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_Programming
{
    class WindMill
    {
        public static void Mt()
        {
            Console.WriteLine("enter the value of temperature");
            double t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the value wind speed");
            double v = Convert.ToDouble(Console.ReadLine());
            double w = 0;
            if ((t > 50) || (v > 120 && v < 3))
            {
                Console.WriteLine("invalid data");
            }
            else
            {
                w = 35.74 + 0.6215 * t + Math.Pow((0.4275 * t - 35.75) * v, 0.16);
            }
            Console.WriteLine("temperature in fahrenheit is :" + t);
            Console.WriteLine("speed in miles per hour is :" + v);
            Console.WriteLine("wind chill speed is :" + w);
        }
    }
}
