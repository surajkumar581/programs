using System;
using System.Collections.Generic;
using System.Text;

namespace Functional_Programming
{
    class MonthlyPayment
    {
        
        
            /// <summary>
            /// Ispayments the specified p.
            /// </summary>
            /// <param name="P">The p.</param>
            /// <param name="Y">The y.</param>
            /// <param name="R">The r.</param>
            public static void Ispayment()
            {
            Console.WriteLine("enter the value of P");
            double P = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the value of Y");
            int Y= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of R");
            double R = Convert.ToDouble(Console.ReadLine());

            //int n = int.Parse(Console.ReadLine());
            int n = Y * 12;
                Console.WriteLine("n =" + n);
                double r = R / (12 * 100);
                Console.WriteLine("r =" + r);
                double pmt = (P * r) / (Math.Pow(1 - (1 + r), -n));
                Console.WriteLine("monthly payment is =" + pmt);
            }


        }
    }

  





