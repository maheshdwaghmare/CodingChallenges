using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    public class UnionIntersection
    {
        static void printUnion(int[] arr1, int[] arr2)
        {
            HashSet<int> hs = new HashSet<int>();

            for (int i = 0; i < arr1.Length; i++)
                hs.Add(arr1[i]);
            for (int i = 0; i < arr2.Length; i++)
                hs.Add(arr2[i]);

            Console.WriteLine(string.Join(", ", hs));
        }

        // Prints intersection of arr1[0..m-1] and arr2[0..n-1] 
        static void printIntersection(int[] arr1, int[] arr2)
        {
            HashSet<int> hs = new HashSet<int>();

            for (int i = 0; i < arr1.Length; i++)
                hs.Add(arr1[i]);

            for (int i = 0; i < arr2.Length; i++)
                if (hs.Contains(arr2[i]))
                    Console.Write(arr2[i] + " ");
        }

        // Driver Code 
        static void Main()
        {
            int[] arr1 = { 7, 1, 5, 2, 3, 6 };
            int[] arr2 = { 3, 8, 6, 20, 7 };

            Console.WriteLine("Union of two arrays is : ");
            printUnion(arr1, arr2);

            Console.WriteLine("\nIntersection of two arrays is : ");
            printIntersection(arr1, arr2);

            Console.ReadKey();
        }
    }
}
