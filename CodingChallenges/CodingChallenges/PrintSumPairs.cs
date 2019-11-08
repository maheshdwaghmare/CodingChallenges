using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    public class PrintSumPairs
    {
        // Time Complexity: O(n) n :- Size of Array
        static void printpairs(int[] arr, int sum)
        {
            HashSet<int> s = new HashSet<int>();
            for (int i = 0; i < arr.Length; ++i)
            {
                int temp = sum - arr[i];

                // checking for condition 
                if (s.Contains(temp))
                {
                    Console.Write("Pair with given sum " + sum + " is (" + arr[i] + ", " + temp + ")");
                }
                s.Add(arr[i]);
            }
        }
        //static void Main(string[] args)
        //{
        //    int[] A = new int[] { 1, 2, -2, 3, 4, 5 };
        //    int n = 2;
        //    printpairs(A, n);
        //    Console.ReadKey();
        //}
    }
}
