using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sum.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int Result = 0, n;
            while (true)
            {
                Console.WriteLine("Enter a number: ");
                string input = Console.ReadLine();
                n = Convert.ToInt32(input);


                if (n > 999)
                {
                    break;
                }
                else
                {
                Result = Result + n;
                }
                    System.Console.WriteLine(Result);
            }
        }
    }
}
