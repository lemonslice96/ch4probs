﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnsureValidRateLoop.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;
            while (true)
            {
                Console.WriteLine("Enter hourly payrate: ");
                string input = Console.ReadLine();
                n = Convert.ToDouble(input);
                if (n < 5.65d || n > 49.99)
                {
                    Console.WriteLine("Enter hourly payrate: ");
                    input = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
        }
    }
}
