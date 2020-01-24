using System;
using System.Collections.Generic;
using System.Text;
using FunctionalProgramming;

namespace Functional_Programming
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.name");
            Console.WriteLine("enter the 2");
            Console.WriteLine("enter the 3");
            Console.WriteLine("enter the 4");
            Console.WriteLine("enter the 5");
            Console.WriteLine("enter the 6");
            Console.WriteLine("enter the 7");
            Console.WriteLine("enter the 8");
            Console.WriteLine("enter the 9");
            Console.WriteLine("enter the 10");
            Console.WriteLine("enter the 11");
            Console.WriteLine("enter the 12");
            Console.WriteLine("enter the 13");
            Console.WriteLine("enter the 14");
            Console.WriteLine("enter the 15");
            Console.WriteLine("enter the 16");
            Console.WriteLine("enter the 17");
            Console.WriteLine("enter the 18");
            Console.WriteLine("enter the 19");
            Console.WriteLine("enter the 20");
            Console.WriteLine("enter the 21");
            Console.WriteLine("enter the 22");
            Console.WriteLine("enter the choice");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Anagram.IsAnagram();
                    break;
                case 2:
                    Armstrong.IsArmstrong1();
                    break;
                case 3:
                    BinarySearch.Binary1();
                    break;
                case 4:
                    BubbleSort.Bubble12();
                    break;
                case 5:
                    ClanderDayWeek.isDay();
                    break;
                case 6:
                    CoupanCode1.Mt();
                    break;
                case 7:
                    DecimalToBinary.IsBinary();
                    break;
                case 8:
                    Dice.IsDice();
                    break;
                case 9:
                    Distance.Bw();
                    break;
                case 10:
                    Equal.IsEqual();
                    break;

                case 11:
                    Factor.fac();
                    break;
                case 12:
                    Flipcoin.IsCoin();
                    break;
                case 13:
                    Glamber.IsGambler();
                    break;
                case 14:
                    HarmonicNumber.Har();
                    break;
                case 15:
                    InsertionSort.Insertion();
                    break;
                case 16:
                    Leapyear.Leap();
                    break;
                case 17:
                    MonthlyPayment.Ispayment();
                    break;
                case 18:
                    Power.Power12();
                    break;
                case 19:
                    Quardratic.Bk();
                    break;
                case 20:
                    Replace.Rep();
                    break;
                case 21:
                    Reverse.IsReverse();
                    break;
                case 22:
                    StopWatch.Stop();
                    break;

            }
        }
    }
}
