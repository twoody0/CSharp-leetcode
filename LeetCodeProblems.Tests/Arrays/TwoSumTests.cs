namespace LeetCodeProblems.Tests.Arrays;

public class TwoSumTests
{
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9)]
    public void FindTwoSum_ValidNumbers_ReturnsArgument(int[] nums, int target)
    {
        // Arrange
        int[] expected = { 0, 1 };

        // Act
        int[] actual = TwoSum.FindTwoSum(nums, target);

        // Assert
        Assert.Equal(actual, expected);
    }
}