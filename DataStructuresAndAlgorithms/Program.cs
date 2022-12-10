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
        static int binarySearch(String[] arr, String x)
        {
            int l = 0, r = arr.Length - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;

                int res = x.CompareTo(arr[m]);
                if (res == 0)
                    return m;
                if (res > 0)
                    l = m + 1;
                else
                    r = m - 1;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            String[] arr = { "Ab", "cd", "ef", "gh" };
            Console.WriteLine("Enter the word you want to search");
            String x = Convert.ToString(Console.ReadLine());
            int result = binarySearch(arr, x);
            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at "
                                + "index " + result);

        }
    }
}
