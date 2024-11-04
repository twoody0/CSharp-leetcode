namespace LeetCodeProblems.Tests.Arrays;

public class DynamicArrayTests
{
    [Fact]
    public void Constructor_GivenCapacity_InitializesDynamicArray()
    {
        // Arrange
        int capacity = 5;
        DynamicArray arr = new(capacity);

        // Act
        int actual = arr.Capacity;

        // Assert
        Assert.Equal(actual, capacity);
    }

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