using LeetCode._1.ArrayAndStrings;

namespace LeetCode.Test._1.ArraysAndStrings
{
    public class P1768Test
    {
        [Fact]
        public void MergeAlternately_ShouldReturnMergedString()
        {
            // Arrange
            var mergeString = new PI1678_MergeString();
            string word1 = "abc";
            string word2 = "pqr";
            string expected = "apbqcr";
            // Act
            string result = mergeString.MergeAlternately(word1, word2);
            // Assert
            Assert.Equal(expected, result);
        }

        public void MergeAlternately_Word2Longer()
        {
            //Arrange
            var mergeString = new PI1678_MergeString();
            string word1 = "ab";
            string word2 = "pqrs";
            string expected = "apbqrs";
            //Act
            string result = mergeString.MergeAlternately(word1, word2);
            //Assert
            Assert.Equal(expected, result);
        }

        public void MergeAlternately_Word1Longer()
        {
            //Arrange
            var mergeString = new PI1678_MergeString();
            string word1 = "abcd";
            string word2 = "pq";
            string expected = "a p b q c   d";
            //Act
            string result = mergeString.MergeAlternately(word1, word2);
            //Assert
            Assert.Equal(expected, result);
        }

    }
}
