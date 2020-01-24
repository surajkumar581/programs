using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_Programming
{



        class Reverse
        {

            public static void IsReverse()

            {
            Console.WriteLine("enter the value of n");
            int n = Convert.ToInt32(Console.ReadLine());
                int rev = 0, sum = 0;

                while (n > 0)
                {
                    rev = n % 10;
                    sum = sum * 10 + rev;
                    n = n / 10;
                }
                Console.WriteLine(sum);

            }
        }
    }


