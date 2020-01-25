﻿using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Utility Class
/// </summary>
public class Utility
{
    /// <summary>
    /// Determines whether the specified input is integer.
    /// </summary>
    /// <param name="input">The input.</param>
    /// <returns>
    /// Returns the integer value
    /// </returns>
    public static int IsInteger(string input)
    {
        int number;
        if (int.TryParse(input, out number))
        {
            return Convert.ToInt32(input);
        }
        else
        {
            while (int.TryParse(input, out number) == false)
            {
                Console.WriteLine("please enter a proper integer");
                input = Console.ReadLine();
            }

            return Convert.ToInt32(input);
        }
    }

    /// <summary>
    /// Determines whether the specified input is double.
    /// </summary>
    /// <param name="input">The input.</param>
    /// <returns>
    /// Returns the double value
    /// </returns>
    public static double IsDouble(string input)
    {
        double number;
        if (double.TryParse(input, out number))
        {
            return number;
        }
        else
        {
            while (double.TryParse(input, out number) == false)
            {
                Console.WriteLine("please enter a proper integer");
                input = Console.ReadLine();
            }

            return number;
        }
    }

    /// <summary>
    /// Determines whether the specified input is string.
    /// </summary>
    /// <param name="input">The input.</param>
    /// <returns>
    /// Returns the string
    /// </returns>
    public static string IsString(string input)
    {
        int flag = 1;
        do
        {
            ////check if the input has whitespace
            if (input.Contains(" "))
            {
                Console.WriteLine("the string entered has a whitespace. please enter a proper string");
                input = Console.ReadLine();
            }
            ////check if the input has number or not
            for (int i = 0; i < 10; i++)
            {
                if (input.Contains(i.ToString()))
                {
                    flag = 1;
                    Console.WriteLine("the string entered has a number. please enter a proper string");
                    input = Console.ReadLine();
                    break;
                }
                else
                {
                    flag = 0;
                }
            }
        }
        while (flag == 1);
        return input;
    }

    /// <summary>
    /// Determines whether the specified input is boolean.
    /// </summary>
    /// <param name="input">The input.</param>
    /// <returns>
    ///   <c>true</c> if the specified input is boolean; otherwise, <c>false</c>.
    /// </returns>
    public static bool IsBoolean(string input)
    {
        input.ToLower();
        ////check the value of input if its true or false
        while (string.Equals(input, "true") != true && string.Equals(input, "false") != true)
        {
            input.ToLower();
            Console.WriteLine("please enter a boolean value");
            input = Console.ReadLine();
        }

        return input.Equals("true") ? true : false;
    }

    /// <summary>
    /// Twos the d array.
    /// </summary>
    /// <param name="row">The row.</param>
    /// <param name="column">The column.</param>
    /// <returns>
    /// Returns the 2D array
    /// </returns>
    public static int[,] TwoDArray(int row, int column)
    {
        int[,] array = new int[row, column];
        ////read the array
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                array[i, j] = Utility.IsInteger(Console.ReadLine());
            }
        }
        ////print the array
        for (int i = 0; i < row; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < column; j++)
            {
                Console.Write(array[i, j] + " ");
            }
        }

        return array;
    }

    /// <summary>
    /// Randoms the double.
    /// </summary>
    /// <returns>
    /// Returns a random double value
    /// </returns>
    public static double RandomDouble()
    {
        Random rand = new Random();
        return rand.NextDouble();
    }

    /// <summary>
    /// Randoms the int.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="max">The maximum.</param>
    /// <returns>
    /// Returns a random integer value
    /// </returns>
    public static int RandomInt(int min, int max)
    {
        Random rand = new Random();
        return rand.Next(min, max + 1);
    }

    /// <summary>
    /// Leaps the year.
    /// </summary>
    /// <param name="year">The year.</param>
    /// <returns>
    /// Returns a boolean value for leap year
    /// </returns>
    public static bool LeapYear(int year)
    {
        bool flag = false;
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            else
            {
                flag = true;
            }
        }
        else
        {
            flag = false;
        }

        if (flag)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Primes the numbers.
    /// </summary>
    /// <param name="min">The minimum.</param>
    /// <param name="max">The maximum.</param>
    /// <returns>
    /// Returns array of prime numbers
    /// </returns>
    public static int[] PrimeNumbers(int min, int max)
    {
        int[] arr = new int[1000];
        int k = 0, count = 0;
        while (min < max)
        {
            bool flag = false;
            for (int i = 2; i <= min / 2; ++i)
            {
                if (min % i == 0)
                {
                    flag = true;
                    break;
                }
            }

            if (!flag)
            {
                Console.WriteLine(min + " ");
                count++;
                arr[k++] = min;
            }
            ++min;
        }

        int[] array = new int[count];
        for (int j = 0; j < count; j++)
        {
            array[j] = arr[j];
        }

        return array;
    }

    /// <summary>
    /// Anagrams the specified num1.
    /// </summary>
    /// <param name="num1">The num1.</param>
    /// <param name="num2">The num2.</param>
    /// <returns>
    /// Returns a boolean value if two numbers are anagram or not
    /// </returns>
    public static bool Anagram(int num1, int num2)
    {
        int[] a = new int[10];
        int[] b = new int[10];
        int count1 = 0;
        int count2 = 0;
        int c = 0;
        while (num1 != 0)
        {
            int n = num1 % 10;
            a[n]++;
            count1++;
            num1 /= 10;
        }

        while (num2 != 0)
        {
            int m = num2 % 10;
            b[m]++;
            count2++;
            num2 /= 10;
        }

        if (count1 != count2)
        {
            return false;
        }
        else
        {
            for (int k = 0; k < 10; k++)
            {
                if (a[k] == b[k])
                {
                    c++;
                }
            }

            if (c == 10)
            {
                return true;
            }
        }

        return false;
    }
}

    

