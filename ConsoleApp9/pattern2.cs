using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
    class pattern2
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 5; i++)
            {
                for(int j = 5; j > i; j--)
                {
                    if (i < j)
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
