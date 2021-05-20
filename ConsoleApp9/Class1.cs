using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
    class Class1
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i<n; i++)
            {
                for(int j = 0; j>i; j++)
                {
                    if (j == n - i-1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
