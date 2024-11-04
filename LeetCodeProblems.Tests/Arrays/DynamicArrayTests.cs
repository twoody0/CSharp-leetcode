namespace LeetCodeProblems.Tests.Arrays;

public class DynamicArrayTests
{
    [Fact]
    public void Get_GivenIndex_ReturnsElement()
    {
        // Arrange
        DynamicArray arr = new(3);

        arr.PushBack(3);
        arr.PushBack(5);
        arr.PushBack(1);

        int expectedVal = 3;

        // Act
        int actual = arr.Get(0);

        // Assert
        Assert.Equal(expectedVal, actual);
    }
}