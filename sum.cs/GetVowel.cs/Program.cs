﻿                                              using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetVowel.cs
{
    class Program
    {
        static void Main(string[] args)
        {
           
            while (true)
            { 
                Console.WriteLine("Enter a vowel: ");
                string input = Console.ReadLine().ToLower();
                if (input == "a" || input == "e" || input == "i" || input == "o" || input == "u")
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("!");
                }

            }
               
            
        }
    }
}
