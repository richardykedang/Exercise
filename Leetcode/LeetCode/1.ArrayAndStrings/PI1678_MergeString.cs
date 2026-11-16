using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._1.ArrayAndStrings
{
    public class PI1678_MergeString
    {
        public string MergeAlternately(string word1, string word2)
        {
            StringBuilder merged = new StringBuilder();
            int MaxLength = Math.Max(word1.Length, word2.Length);

            for (int i = 0; i < MaxLength; i++)
            {
                if(i < word1.Length)
                {
                    merged.Append(word1[i]);
                }

                if(i < word2.Length)
                {
                    merged.Append(word2[i]);
                }
            }

            return merged.ToString();
        }
    }
}
