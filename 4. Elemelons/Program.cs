using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._Elemelons
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            List<char[,]> layers = new List<char[,]>();

            for (int i = 0; i < size; i++)
            {
                char[,] layer = new char[size, size];
                layers.Add(layer);
            }

            //list of layers -> layers 3dim Array
            for (int i = 0; i < size; i++)
            {
                string input = Console.ReadLine();
                string[] row = input.Split("|",StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int j = 0; j < row.Length; j++)
                {
                    char[] currRow = row[j].Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                    for (int k = 0; k < currRow.Length; k++)
                    {
                        char currChar = currRow[k];
                        layers[j][i, k] = currChar;
                    }
                }
            }
            while (true)
            {
                string inputText = Console.ReadLine();
                if (inputText == "Melolemonmelon")
                {
                    break;
                }
                int[] coordCell = inputText.Split(' ').Select(int.Parse).ToArray();

                int layer = coordCell[0];
                int row = coordCell[1];
                int column = coordCell[2];

                layers[layer][row, column] = '0';

                for (int i = 0; i < layers.Count; i++)
                {
                    char[,] currLayer = layers[i];
                    for (int j = 0; j < currLayer.GetLength(0); j++)
                    {
                        for (int m = 0; m < currLayer.GetLength(1); m++)
                        {
                            char currSimbol = currLayer[j, m];
                            if ((i == layer - 1 && j == row && m == column) || (i == layer + 1 && j == row && m == column))
                            {
                                continue;
                            }
                            else if ((i == layer && j == row && m == column - 1) ||
                                (i == layer && j == row && m == column + 1) ||
                                (i == layer && j == row - 1 && m == column) ||
                                (i == layer && j == row + 1 && m == column))
                            {
                                continue;
                            }
                            else
                            {
                                switch (currSimbol)
                                {
                                    case 'W':
                                        layers[i][j, m] = 'E';
                                        break;
                                    case 'E':
                                        layers[i][j, m] = 'F';
                                        break;
                                    case 'F':
                                        layers[i][j, m] = 'A';
                                        break;
                                    case 'A':
                                        layers[i][j, m] = 'W';
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            int rowIndex = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < layers.Count; j++)
                {
                    char[,] currLayer = layers[j];

                    for (int k = 0; k < currLayer.GetLength(1); k++)
                    {
                        char currSimbol = currLayer[rowIndex, k];
                        if (j == layers.Count - 1 && k == currLayer.GetLength(1) - 1)
                        {
                            Console.Write(currSimbol);
                            continue;
                        }
                        Console.Write(currSimbol + " ");
                    }
                    if (j != layers.Count - 1)
                    {
                        Console.Write("| ");
                    }
                }
                rowIndex++;
                Console.WriteLine();
            }
        }
    }
}
