using System;
using System.Collections.Generic;
using System.Linq;


namespace CodingChallenges
{
    class Split
    {
        //public static int solution(string S, int K)
        //{
        //var words = new List<string>();

        //int count = 0;
        //for (int i = 0; i < S.Length; i += K)
        //{
        //    count++;
        //    if (S.Length - i >= K && S[count * K + 1] == ' ')
        //        words.Add(S.Substring(i, K));
        //    else if (S[count * K + 1] == ' ')
        //        words.Add(S.Substring(i, S.Length - i));
        //    else
        //        return -1;
        //}

        //return words.Count();
        //}

        public static int solution(string S, int K)
        {
            string[] words = S.Split(' ');
            var parts = new Dictionary<int, string>();
            string part = string.Empty;
            int partCounter = 0;
            foreach (var word in words)
            {
                if (part.Length + word.Length < K)
                {
                    part += string.IsNullOrEmpty(part) ? word : " " + word;
                }
                else
                {
                    if (word.Length > K)
                        return -1;

                    parts.Add(partCounter, part);
                    part = word;
                    partCounter++;
                }
            }

            parts.Add(partCounter, part);
            return parts.Count;
        }


        //public static void Main()
        //{
        //    int i = solution("I like to play Chesssdfasdf and Cricket", 9);
        //    Console.WriteLine("Count: " + i);
        //}
    }
}
