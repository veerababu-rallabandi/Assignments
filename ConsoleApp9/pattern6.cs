using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
    class pattern6
    {
        public void Method1()
        {
            int n = 5;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(i==0 || j==0|| j == n - 1 || i == (int)n / 2)
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
            Console.WriteLine();
        }
        public void Method2()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i <= j)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            
        }
        public void Method3()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 5; j > i; j--)
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
            Console.WriteLine();
        }
        public void Method4()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i >= j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine('\t');
            }
        }
        public void Method5()
        {
            int n = 5;
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(i==0 || j==0 || i == n - 1|| i==(int)n/2)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }    
                Console.WriteLine('\t');

            }

        }
        public void Method6()
        {
            Console.WriteLine();
            int n = 5;
           
            for (int i = n; i > 0; i--)
            {
                for (int j = n; j > 0; j--)
                {
                    if (i <= j)
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

        public void Method7()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j || j == 5 - 1 - i)
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
   
