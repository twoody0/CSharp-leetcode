# Dynamic Array

## Problem Description

Implement a **Dynamic Array** class that supports the following operations:
- `Get(i)`: Returns the element at index `i`.
- `Set(i, n)`: Sets the element at index `i` to `n`.
- `PushBack(n)`: Adds an element `n` to the end of the array, resizing if necessary.
- `PopBack()`: Removes and returns the last element in the array.
- `GetSize()`: Returns the current number of elements in the array.
- `GetCapacity()`: Returns the current capacity of the array.

The dynamic array should automatically resize when the number of elements exceeds its current capacity.

## Key Concepts

A **Dynamic Array** is a data structure that grows and shrinks dynamically as elements are added or removed. Unlike static arrays, dynamic arrays resize themselves when the current capacity is exceeded.

- **Initial Capacity**: The array starts with a specified capacity.
- **Resizing**: When the number of elements exceeds the capacity, the array doubles its capacity. This is managed internally by the `Resize` method.

## Methods

### Constructor

- **`DynamicArray(int capacity)`**: Initializes the dynamic array with a specified initial capacity.

### Get/Set Operations

- **`Get(int i)`**: Returns the element at index `i`. If `i` is out of bounds, an exception should be thrown (not implemented in this code).
- **`Set(int i, int n)`**: Sets the element at index `i` to `n`. If `i` is out of bounds, an exception should be thrown (not implemented in this code).

### Adding and Removing Elements

- **`PushBack(int n)`**: Adds the element `n` to the end of the array. If the array is full, it triggers the `Resize` operation to increase the capacity.
- **`PopBack()`**: Removes and returns the last element in the array. If the array is empty, an exception should be thrown (not implemented in this code).

### Helper Methods

- **`Resize()`**: Doubles the capacity of the array when the current capacity is exceeded. This method is called internally by `PushBack`.

### Size and Capacity

- **`GetSize()`**: Returns the current number of elements in the array.
- **`GetCapacity()`**: Returns the current capacity of the array, which may be larger than the current number of elements.

## Example Usage

```csharp
DynamicArray dynamicArray = new (2);
dynamicArray.PushBack(10);     // Adds 10 to the array
dynamicArray.PushBack(20);     // Adds 20 to the array
dynamicArray.PushBack(30);     // Triggers resize, then adds 30

Console.WriteLine(dynamicArray.Get(0)); // Outputs 10
Console.WriteLine(dynamicArray.GetSize()); // Outputs 3
Console.WriteLine(dynamicArray.GetCapacity()); // Capacity should be at least 4 after resizing
dynamicArray.PopBack();          // Removes the last element (30)
