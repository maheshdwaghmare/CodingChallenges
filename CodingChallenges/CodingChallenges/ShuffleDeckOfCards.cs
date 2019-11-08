using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    public class ShuffleDeckOfCards
    {
        public static void shuffle(int[] card, int n)
        {

            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                // Random for remaining positions. 
                int r = i + rand.Next(52 - i);

                //swapping the elements 
                int temp = card[r];
                card[r] = card[i];
                card[i] = temp;

            }
        }
        //static void Main(string[] args)
        //{
        //    // Array from 0 to 51 
        //    int[] a = {0, 1, 2, 3, 4, 5, 6, 7, 8,
        //           9, 10, 11, 12, 13, 14, 15,
        //           16, 17, 18, 19, 20, 21, 22,
        //           23, 24, 25, 26, 27, 28, 29,
        //           30, 31, 32, 33, 34, 35, 36,
        //           37, 38, 39, 40, 41, 42, 43,
        //           44, 45, 46, 47, 48, 49, 50,
        //           51};

        //    shuffle(a, 52);

        //    // Printing all shuffled elements of cards 
        //    for (int i = 0; i < 52; i++)
        //        Console.Write(a[i] + " ");

        //    Console.ReadKey();
        //}

        //static void Main()
        //{
        //    //Console.OutputEncoding = System.Text.Encoding.UTF8;

        //    for (int i = 2; i <= 14; i++)
        //    {
        //        for (int j = 5; j < 7; j--)
        //        {
        //            if (i < 11)
        //            {
        //                Console.Write("{0}{1} ", i, (char)j);
        //            }
        //            switch (i)
        //            {
        //                case 11:
        //                    Console.Write("J{0} ", (char)j);
        //                    break;
        //                case 12:
        //                    Console.Write("Q{0} ", (char)j);
        //                    break;
        //                case 13:
        //                    Console.Write("K{0} ", (char)j);
        //                    break;
        //                case 14:
        //                    Console.Write("A{0} ", (char)j);
        //                    break;
        //            }
        //            if (j == 3)
        //            {
        //                j = 7;
        //            }
        //            if (j == 6)
        //            {
        //                break;
        //            }
        //        }

        //        Console.WriteLine();
        //    }

        //    Console.ReadKey();
        //}
    }
}
