using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvenNums1.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
