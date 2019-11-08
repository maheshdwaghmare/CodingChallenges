using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    public class Anagrams
    {

        static int NO_OF_CHARS = 256;

        /* function to check whether two  
        strings are anagram of each other */
        static bool areAnagram(String str1, String str2)
        {
            // Create two count arrays and initialize 
            // all values as 0 
            int[] count = new int[NO_OF_CHARS];
            int i;

            // For each character in input strings,  
            // increment count in the corresponding  
            // count array 
            for (i = 0; i < str1.Length &&
                        i < str2.Length; i++)
            {
                count[str1[i]]++;
                count[str2[i]]--;
            }

            // If both strings are of different length. 
            // Removing this condition will make the program  
            // fail for strings like "aaca" and "aca" 
            if (str1.Length != str2.Length)
                return false;

            // See if there is any non-zero value in  
            // count array 
            for (i = 0; i < NO_OF_CHARS; i++)
                if (count[i] != 0)
                    return false;
            return true;
        }

        // This function prints all anagram pairs in a  
        // given array of strigns 
        static void findAllAnagrams(String[] arr, int n)
        {
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if (areAnagram(arr[i], arr[j]))
                        Console.WriteLine(arr[i] +
                        " is anagram of " + arr[j]);
        }
        //public static void Main()
        //{
        //    String[] arr = {"geeksquiz", "geeksforgeeks",
        //                "abcd", "forgeeksgeeks",
        //                "zuiqkeegs"};
        //    int n = arr.Length;
        //    findAllAnagrams(arr, n);
        //}
    }
}
