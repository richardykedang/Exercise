using LeetCode._1.ArrayAndStrings;

namespace LeetCode.Test._1.ArraysAndStrings
{
    public class _1071Test
    {
        [Fact]
        public void GcdOfStrings_ShouldReturnGCDString()
        {
            // Arrange
            var gcdString = new P1071_GCDString();
            string str1 = "ABCABC";
            string str2 = "ABC";
            string expected = "ABC";
            // Act
            string result = gcdString.GcdOfStrings(str1, str2);
            // Assert
            Assert.Equal(expected, result);
        }
    }
}
