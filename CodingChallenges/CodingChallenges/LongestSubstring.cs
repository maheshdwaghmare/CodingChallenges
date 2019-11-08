using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    public class LongestSubstring
    {
        public static int lengthOfLongestSubstring(String s)
        {
            int length = 0;
            for (int start = 0; start < s.Length; start++)
            {
                int i = start;
                var dictionary = new Dictionary<char, int>();

                while (i < s.Length && !dictionary.ContainsKey(s[i]))
                {
                    dictionary.Add(s[i++], 1);
                }

                if (i - start > length)
                {
                    length = i - start;
                }
            }

            return length;
        }

        //public static void Main(String[] args)
        //{
        //    int length = lengthOfLongestSubstring("pwwkew");
        //}
    }
}
