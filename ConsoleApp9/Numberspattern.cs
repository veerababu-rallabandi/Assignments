using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
    class Numberspattern
    {
        public void Method1()
        {
            int n = 5;
            for(int i = 0; i <n; i++)
            {
                for(int j = 0; j <n; j++)
                {
                    if (i>=j)
                    {
                        Console.Write(i+1);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void Method2()
        {

            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j <= i)
                    {
                        Console.Write(j);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void Method3()
        {
            int n = 5;
            for(int i = 0; i<n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (i>=j)
                    {
                        Console.Write(n-i);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void Method4()
        {
            int n = 5;
            for(int i = n; i >= 1; i--)
            {
                for(int j = n; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        public void Method5()
        {
            int c = 1;
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if (i >= j)
                    {
                        Console.Write(c);
                        c++;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void Method6()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine((int)Math.Pow(11, i));
            }
            
        }
    }
}
