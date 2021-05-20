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
            for(int i = 5; i>0; i--)
            {
                for(int j = 5; j>0; j--)
                {
                    if (i<=j)
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
