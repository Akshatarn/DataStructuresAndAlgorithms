using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    internal class Program
    {
        static int[] InsertionSort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
            return inputArray;
        }
        public static void PrintArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i.ToString() + "  ");
            }
        }
        static void Main(string[] args)
        {
            int[] numberList = new int[] { 34, 67, 53, 74, 84, 12, 9 };
            Console.WriteLine("Unsorted(Initial) Array is:");
            PrintArray(numberList);
            InsertionSort(numberList);
            Console.WriteLine("Sorted array after insertion sort is :");
            PrintArray(numberList);

        }
    }
}
