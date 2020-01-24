using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_Programming
{
    class Factor
    {
        public static void fac()
        {
            int i, fact = 1, number;
            Console.WriteLine("enter any number:");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact *= i;
            }
            Console.Write("factorial of" + number + "is" + fact);
        }
    }
}
