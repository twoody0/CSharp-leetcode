namespace LeetCodeProblems.Arrays;

public class DynamicArray
{
    private int[] _array;
    private int _size;
    private int _capacity;
    public int Size => _size;
    public int Capacity => _capacity;

    public DynamicArray(int capacity)
    {
        _capacity = capacity;
        _array = new int[_capacity];
        _size = 0;
    }

    public int Get(int i)
    {
        return 0;
    }

    public void Set(int i, int n)
    {
    }

    public void PushBack(int n)
    {
    }

    public int PopBack()
    {
        return 0;
    }

    private void Resize()
    {
    }

    public int GetSize()
    {
        return 0;
    }

    public int GetCapacity()
    {
        return 0;
    }
}