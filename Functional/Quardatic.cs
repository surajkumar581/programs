using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_Programming
{
    class Quardratic
    {
        public static void Bk()
        {

        
        int a, b, c;
        double d, x1, x2;
        Console.Write("\n\n");
            Console.Write("calculate root of Quadratic Equation :\n");
            Console.Write("     ");
            Console.Write("\n\n");
            Console.Write("input the value of a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("input the value of b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("input the value of c:");
            c = Convert.ToInt32(Console.ReadLine());
            d = b* b - 4 * a* c;
            if (d == 0)//if  d==0 then we get 2 differt root
            {
                Console.Write("both are equal.\n");
                x1 = -b / (2.0);
                x2 = x1;
                Console.Write("first root root1={0}\n", x1);
                Console.Write("second root root2={0}\n", x2);
            }
            else if (d > 0)
            {

                Console.Write("both roots are real1 and diff-2/n");
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.Write("first root root1={0}\n", x1);
                Console.Write("second root root2={0}\n", x2);
            }
            else
                Console.Write("root are imaginary;\n No Solution.\n\n");


        }
    }
}

    

