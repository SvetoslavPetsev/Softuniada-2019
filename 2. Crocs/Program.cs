using System;

namespace _2._Crocs
{
    class Program
    {
        static void Main()
        {
            int oddN = int.Parse(Console.ReadLine());

            int with = oddN * 5;
            int hight = oddN * 4 + 2;

            //draw head lines

            int headLines = oddN / 2;

            for (int i = 0; i < headLines; i++)
            {
                for (int j = 0; j < oddN; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < oddN * 3; k++)
                {
                    Console.Write("#");
                }
                for (int j = 0; j < oddN; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            
            //draw topLine

            for (int j = 0; j < oddN; j++)
            {
                Console.Write("#");
            }
            for (int j = 0; j < oddN * 3; j++)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < oddN; k++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
            
            //draw top pattern
            int topPatternLines = (hight / 2) - 2; //error
            if (topPatternLines % 2 == 0 )
            {
                topPatternLines++;
            }
            int patternPoints = (with - 2 * oddN) / 2 + 1;
            for (int i = 0; i < topPatternLines; i++)
            {
                for (int j = 0; j < oddN; j++)
                {
                    Console.Write("#");
                }
                if (i % 2 == 0)
                {
                    for (int m = 0; m < patternPoints; m++)
                    {
                        if (m == patternPoints - 1)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write(" #");
                        }
                    }
                }

                if (i % 2 == 1)
                {
                    for (int m = 0; m < patternPoints; m++)
                    {
                        if (m == 0)
                        {
                            Console.Write(" ");
                        }
                        else if (m == patternPoints - 1)
                        {
                            Console.Write("  ");
                        }
                        else
                        {
                            Console.Write(" #");
                        }
                    }
                }
                for (int k = 0; k < oddN; k++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            //drow bottLine

            for (int j = 0; j < oddN; j++)
            {
                Console.Write("#");
            }
            for (int j = 0; j < oddN * 3; j++)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < oddN; k++)
            {
                Console.Write("#");
            }
            Console.WriteLine();

            //bottom pattern

            int bottomPatternLines = (hight - 2 * headLines - topPatternLines); //error

            for (int i = 0; i < bottomPatternLines - 2; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < with; j++)
                    {
                        Console.Write("#");
                    }
                }
                else
                {
                    for (int j = 0; j < oddN; j++)
                    {
                        Console.Write("#");
                    }

                    // midd
                    for (int m = 0; m < patternPoints; m++)
                    {
                        if (m == patternPoints - 1)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write(" #");
                        }
                    }

                    for (int j = 0; j < oddN; j++)
                    {
                        Console.Write("#");
                    }
                }
                Console.WriteLine();
            }

            //foot

            for (int i = 0; i < headLines; i++)
            {
                for (int j = 0; j < oddN; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < oddN * 3; k++)
                {
                    Console.Write("#");
                }
                for (int j = 0; j < oddN; j++)
                {
                    Console.Write(" ");
                }
                if (i != headLines - 1)
                {
                    Console.WriteLine();
                }

            }
        }
    }
}
