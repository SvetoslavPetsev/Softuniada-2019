using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Nexus
{
    class Program
    {
        static bool IsValidIndexes(List<int> arr, int index1, int index2)
        {
            bool isValid = false;
            int maxIndex = Math.Max(index1, index2);
            if (arr.Count - 1 >= maxIndex)
            {
                isValid = true;
            }
            return isValid;
        }
        static bool IsCroosed(int[] index1122, int[] index2112)
        {
            bool crossed = false;
            if (index1122[1] > index2112[1] && index1122[0] < index2112[0])
            {
                crossed = true;
            }
            else if (index1122[1] < index2112[1] && index1122[0] > index2112[0])
            {
                crossed = true;
            }
            return crossed;
        }
        static void RemoveElementsBetween(List<int> arr, int firstIndex, int secondIndex)
        {
            int start = Math.Min(firstIndex, secondIndex);
            int end = Math.Max(firstIndex, secondIndex);
            int count = end - start + 1;
            arr.RemoveRange(start, count);
        }
        static void IncreaseElements(List<int> arr, int number)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                arr[i] += number;
            }
        }
        static void Main()
        {
            List<int> arr1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> arr2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "nexus")
                {
                    break;
                }
                string[] indexes = input.Split('|');
                int[] index1122 = indexes[0].Split(':', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int[] index2112 = indexes[1].Split(':', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                if (IsValidIndexes(arr1, index1122[0], index2112[0]) && IsValidIndexes(arr2, index2112[1], index1122[1]))
                {
                    int sumOfIndexes = arr1[index1122[0]] + arr1[index2112[0]] + arr2[index2112[1]] + arr2[index1122[1]];
                    if (IsCroosed(index1122, index2112))
                    {
                        RemoveElementsBetween(arr1, index1122[0], index2112[0]);
                        IncreaseElements(arr1, sumOfIndexes);
                        RemoveElementsBetween(arr2, index2112[1], index1122[1]);
                        IncreaseElements(arr2, sumOfIndexes);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", arr1));
            Console.WriteLine(string.Join(", ", arr2));
        }
    }
}
