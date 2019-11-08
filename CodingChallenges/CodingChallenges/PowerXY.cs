using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    public class PowerXY
    {
        // Positive nos
        /* Function to calculate x raised to the power y in O(logn)*/
        //static int power(int x, int y)
        //{
        //    int temp;
        //    if (y == 0)
        //        return 1;
        //    temp = power(x, y / 2);
        //    if (y % 2 == 0)
        //        return temp * temp;
        //    else
        //        return x * temp * temp;
        //}

        // Negative nos
        static float power(float x, int y)
        {
            float temp;

            if (y == 0)
                return 1;
            temp = power(x, y / 2);

            if (y % 2 == 0)
                return temp * temp;
            else
            {
                if (y > 0)
                    return x * temp * temp;
                else
                    return (temp * temp) / x;
            }
        }
        //static void Main(string[] args)
        //{
        //    //int x = 2;
        //    //int y = -4;

        //    float x = 2;
        //    int y = 0;

        //    Console.Write(power(x, y));
        //    Console.ReadKey();
        //}
    }
}
