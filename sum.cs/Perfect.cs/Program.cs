using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Perfect.cs
{
    class Program
    {
        static void Main(string[] args)
        {
           
            for (int i = 1; i <= 1000; i++)
            {
                int sum = 0;
                for (int l = 1; l < i; l++)
                {
                    if (i % l == 0)
                    {
                        sum = sum + l;
                    }
                }
                if (sum == i)
                {
                    Console.WriteLine(sum);
                }
            }

        }
    }
}
