namespace LeetCodeProblems.Tests.Arrays;

public class TwoSumTests
{
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    public void FindTwoSum_ValidNumbers_ReturnsExpectedIndicies(int[] nums, int target, int[] expected)
    {
        // Arrange

        // Act
        int[] actual = TwoSum.FindTwoSum(nums, target);

        // Assert
        Assert.Equal(actual, expected);
    }
}