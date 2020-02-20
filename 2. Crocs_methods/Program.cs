using System;

namespace _2._Crocs_methods
{
    class Program
    {
        static void DrawHeadFoot(int n, int with)
        {
            for (int i = 1; i <= with; i++)
            {
                if (i <= n || i >= with - n + 1)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("#");
                }
            }
        }
        static void DrawTopBottomLines(int n, int with)
        {
            for (int i = 1; i <= with; i++)
            {
                if (i <= n || i >= with - n + 1)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }
        static void DrawPatternA(int n, int with)
        {
            for (int i = 1; i <= n; i++)
            {
              Console.Write("#");
            }
            for (int j = 1; j <= with - 2 * n; j++)
            {
                if (j == 1 || j == with - 2 * n)
                {
                    Console.Write(" ");
                }
                else if (j % 2 == 1)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            for (int i = 1; i <= n; i++)
            {
                Console.Write("#");
            }
        }
        static void DrawPatternB(int n, int with)

        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write("#");
            }
            for (int j = 1; j <= with - 2 * n; j++)
            {
                if (j == 1 || j == with - 2 * n)
                {
                    Console.Write(" ");
                }
                else if (j % 2 == 0)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            for (int i = 1; i <= n; i++)
            {
                Console.Write("#");
            }
        }

        static void DrawPatternC(int with)
        {
            for (int i = 0; i < with; i++)
            {
                Console.Write("#");
            }
        }
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int with = N * 5;
            int hight = N * 4 + 2;

            int topBottomLines = N / 2;
            
            for (int i = 0; i < topBottomLines; i++)
            {
                DrawHeadFoot(N, with);
                Console.WriteLine();
            }
           
            DrawTopBottomLines(N, with);
            Console.WriteLine();

            int topPatternLines = hight / 2 - 2;
            for (int i = 0; i < topPatternLines; i++)
            {
                if (i % 2 == 1)
                {
                    DrawPatternA(N, with);
                }
                else
                {
                    DrawPatternB(N, with);
                }
                Console.WriteLine();
            }
            DrawTopBottomLines(N, with);
            Console.WriteLine();
            int bottPatternLines = hight - topBottomLines * 2 - topPatternLines - 2;
            for (int i = 0; i < bottPatternLines; i++)
            {
                if (i % 2 == 0)
                {
                    DrawPatternC(with);
                }
                else
                {
                    DrawPatternB(N, with);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < topBottomLines; i++)
            {
                DrawHeadFoot(N, with);
                Console.WriteLine();
            }
        }
    }
}
