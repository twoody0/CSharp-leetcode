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
        return _array[i];
    }

    public void Set(int i, int n)
    {
        _array[i] = n;
    }

    public void PushBack(int n)
    {
        if (_size == _capacity)
        {
            Resize();
        }
        _array[_size++] = n;
    }

    public int PopBack()
    {
        return 0;
    }

    private void Resize()
    {
        int newCapacity = _capacity * 2;
        int[] newArray = new int[newCapacity];
        for (int i = 0; i < _size; i++)
        {
            newArray[i] = _array[i];
        }
        _array = newArray;
        _capacity = newCapacity;
    }

    public int GetSize()
    {
        return _size;
    }

    public int GetCapacity()
    {
        return _capacity;
    }
}