using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments
{
    enum user
    {
        mahesh,

    }
    class pattern6
    {
       
        public void Method1(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
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
        public void Method2(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = n; j > i; j--)
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
        public void Method3(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
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
        public void Method4(int n)
        {
            Console.WriteLine();
         

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

        public void Method5(int n)
        {
            //A
         
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || j == 0 || j == n - 1 || i == (int)n / 2)
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
        public void Method6(int n)
        {
            //B
            
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || j == 0 || i == n - 1 || j == n - 1 || i == (int)n / 2)
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
        public void Method7(int n)
        {
            //c
            
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (i == 0 || j == 0 || i == n - 1)
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
        public void Method8(int n)
        {
            //D
            
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || j == 0 || i == n - 1 || j == n - 1)
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
        public void Method9(int n)
        {
            //E
            
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
        public void Method10(int n)
        {
            //F
            
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (i == 0 || j == 0 || i == (int)n / 2)
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
        public void Method11(int n)
        {

        }
        public void Method12(int n)
        {
            //H
            
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0 || j == n - 1 || i == (int)n / 2)
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
        public void Method13(int n)
        {
            //I
            
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (i == 0 || i == n - 1 || j == (int)n / 2)
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
        public void Method14(int n)
        {
            //J
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(j==(int)n/2||i==n-1 && j <= (int)n / 2||i==0)
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
        public void Method15(int n)
        {
            //K
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (j == 0 || j == n-1-i&&i<=(int)n/2 || (int)n / 2 <= i && i == j)
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
        public void Method16(int n)
        {
            //L
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (j == 0 || i == n - 1)
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
        public void Method17(int n)
        {
            //M
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(j==0 || j==n-1 || (i==j ||  n-i-1==j) && i <=(int)n / 2)
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
        public void Method18(int n)
        {
            
            //N
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(j==0 || j==n-i-1 || j == n - 1)
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
        public void Method19(int n)
        {
            //o
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(i==0|| j==0|| i==n-1 || j == n - 1)
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
        public void Method20(int n)
        {
            //p
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0 || i == 0 || i==(int)n/2 || i<=(int)n/2&&j==n-1)
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
        public void Method21(int n)
        { 
            //R
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0 || i == 0 || i == (int)n / 2 || i <= (int)n / 2 && j == n - 1 || (int)n/2<=i && i==j)
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
        public void Methodn(int n)
        {
            //X
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
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
        public void Method22(int n)
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (j>= n - i - 1)
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

        public void Methodpa(int n)
        {
            for(int i = 0; i <n; i++)
            {
                //for (int j = i; j < n; j++)
                //{
                //    Console.Write(" ");
                //}
                for (int j = 0; j <(n*2)+1; j++)
                {
                    if(j==(int)n/2 || (j>=n-i && j<=(int)(n*2)/2))
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
        public void MethomM()
        {
            string s = "veerababu"; ;
            char[] a = new char[5];
            s.CopyTo(0, a, 0, 3);
            foreach(char c in a)
            {
                Console.WriteLine(c);
            }

            CharEnumerator aa = s.GetEnumerator();
            string msg = "veerabau,rallabandi,-veera";
            string[] ss=msg.Split(new char[] { ',', '-' },StringSplitOptions.RemoveEmptyEntries);
            foreach(string ss1 in ss)
            {
                Console.WriteLine(ss1);
            }
            Console.WriteLine(s.Equals("VEERABABU", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(s.Clone());
            string msg1 = (string)s.Clone();
            Console.WriteLine(msg1);
            Console.WriteLine(string.Join(",", ss));
            StringBuilder sb = new StringBuilder("veera");
            sb.Append("veera");
            object[] o = new object[] { "welcome", "1" };
            sb.AppendJoin('-',o);
            Console.WriteLine(sb);

            int[][,] aaa = new int[2][,];
            aaa[0] = new int[2, 2] { { 2, 4 }, { 5, 6 } };
            aaa[1] = new int[1, 2] { { 10, 9 } };

            
            Dictionary<Int32, string> dd = new Dictionary<Int32,string>();
            dd.GetEnumerator();
            

        }


    }
}
   
