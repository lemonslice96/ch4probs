using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TableOfSquares.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine("{0} and {1}", i, i * i);
            }
        }
    }
}
