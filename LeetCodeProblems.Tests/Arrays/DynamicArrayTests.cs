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

    [Theory]
    [InlineData(new int[] { 3, 5 }, 1, 5)]
    [InlineData(new int[] { 1, 2, 3 }, 2, 3)]
    public void PushBack_GivenVariable_AddsElement(int[] values, int index, int expectedVal)
    {
        // Arrange
        DynamicArray arr = new(values.Length);

        // Act
        foreach (int value in values)
        {
            arr.PushBack(value);
        }

        // Assert
        Assert.Equal(expectedVal, arr.Get(index));
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