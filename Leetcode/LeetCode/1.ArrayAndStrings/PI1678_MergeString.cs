using System.Text;

namespace LeetCode._1.ArrayAndStrings
{
    public class PI1678_MergeString
    {
        public string MergeAlternately(string word1, string word2)
        {
            char[] merged = new char[word1.Length + word2.Length];
            int MaxLength = Math.Max(word1.Length, word2.Length);
            int index = 0;

            for(int i = 0; i <MaxLength; i++)
            {
                if(i < word1.Length)
                {
                    merged[index++] = word1[i];
                }

                if(i < word2.Length)
                {
                    merged[index++] = word2[i];
                }

            }

            return new string(merged);
        }
    }
}
