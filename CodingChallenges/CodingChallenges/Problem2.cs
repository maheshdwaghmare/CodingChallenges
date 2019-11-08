using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    public class Problem2
    {
        public static int solution(int A, int B)
        {
            int count = 0;
            while (A <= B)
            {
                int m = (int)(Math.Ceiling(Math.Sqrt(A)));
                int n = (int)(Math.Floor(Math.Sqrt(B)));
                if (m == A && n == B)
                    break;
                A = m;
                B = n;
                if (A <= B)
                    count++;
            }
            return count;
        }
        //public static void Main()
        //{
        //    int i = solution(0, 100);
        //}
    }
}
