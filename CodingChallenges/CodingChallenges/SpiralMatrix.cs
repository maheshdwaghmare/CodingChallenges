using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    public class SpiralMatrix
    {
        public static void spiralPrint(int m, int n, int[,] a)
        {
            int i, k = 0, l = 0;
            /* k - starting row index 
            m - ending row index 
            l - starting column index 
            n - ending column index 
            i - iterator 
            */

            while (k < m && l < n)
            {
                // Print the first row from the remaining rows
                for (i = l; i < n; ++i)
                {
                    Console.Write(a[k, i] + " ");
                }
                k++;

                // Print the last column from the remaining columns
                for (i = k; i < m; ++i)
                {
                    Console.Write(a[i, n - 1] + " ");
                }
                n--;

                // Print the last row from the remaining rows
                if (k < m)
                {
                    for (i = n - 1; i >= l; --i)
                    {
                        Console.Write(a[m - 1, i] + " ");
                    }
                    m--;
                }

                // Print the first column from the remaining columns
                if (l < n)
                {
                    for (i = m - 1; i >= k; --i)
                    {
                        Console.Write(a[i, l] + " ");
                    }
                    l++;
                }
            }
        }

        static void print(int[,] arr, int i,
                  int j, int m, int n)
        {
            // If i or j lies outside the matrix 
            if (i >= m || j >= n)
            {
                return;
            }

            // Print First Row 
            for (int p = i; p < n; p++)
            {
                Console.Write(arr[i, p] + " ");
            }

            // Print Last Column 
            for (int p = i + 1; p < m; p++)
            {
                Console.Write(arr[p, n - 1] + " ");
            }

            // Print Last Row, if Last and First Row are not same 
            if ((m - 1) != i)
            {
                for (int p = n - 2; p >= j; p--)
                {
                    Console.Write(arr[m - 1, p] + " ");
                }
            }

            // Print First Column, if Last and First Column are not same 
            if ((n - 1) != j)
            {
                for (int p = m - 2; p > i; p--)
                {
                    Console.Write(arr[p, j] + " ");
                }
            }
            print(arr, i + 1, j + 1, m - 1, n - 1);
        }
        //public static void Main()
        //{
        //    int R = 3;
        //    int C = 6;
        //    int[,] a = { { 1, 2, 3, 4, 5, 6 },
        //              { 7, 8, 9, 10, 11, 12 },
        //              { 13, 14, 15, 16, 17, 18 } };
        //    //spiralPrint(R, C, a);
        //    print(a, 0, 0, R, C);
        //}
    }
}
