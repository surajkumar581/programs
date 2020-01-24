using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_Programming
{
    class Leapyear
    {
        public static void Leap()
        {
            int year;
            Console.WriteLine("enter the year");// enter any no ;
            year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("{0} is a leap year", year);
            }
            else
            {
                Console.WriteLine("{0} is not leap year", year);
            }          
        }
    }
}
