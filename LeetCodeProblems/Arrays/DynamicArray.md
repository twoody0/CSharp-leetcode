# Dynamic Array

## Problem Description

Implement a `DynamicArray` class to mimic a dynamic array data structure. This class should have an initial capacity and should support various operations such as getting and setting elements, pushing and popping elements, resizing, and retrieving the size and capacity of the array. If an element is pushed when the array is full, the array should automatically resize to accommodate the new element.

## Operations

### Constructor
- `DynamicArray(int capacity)`: Initializes an empty array with a specified initial `capacity`. The `capacity` must be greater than 0.

### Methods

- `int get(int i)`: Returns the element at index `i`. Assumes that the index `i` is valid (0 ≤ `i` < `size`).

- `void set(int i, int n)`: Sets the element at index `i` to `n`. Assumes that the index `i` is valid (0 ≤ `i` < `size`).

- `void pushback(int n)`: Adds the element `n` to the end of the array. If the array is full (i.e., `size` equals `capacity`), the array should automatically resize (double its capacity) before adding the new element.

- `int popback()`: Removes and returns the element at the end of the array. Assumes that the array is non-empty.

- `void resize()`: Doubles the capacity of the array. This method is automatically called by `pushback(int n)` if the array is full.

- `int getSize()`: Returns the number of elements currently in the array.

- `int getCapacity()`: Returns the current capacity of the array.

## Example Usage

```plaintext
DynamicArray arr = new (2);  // Initialize with capacity 2
arr.pushback(10);                        // Array: [10]
arr.pushback(20);                        // Array: [10, 20]
arr.pushback(30);                        // Capacity doubles; Array: [10, 20, 30]

int val = arr.get(1);                    // Returns 20
arr.set(1, 40);                          // Array: [10, 40, 30]

int last = arr.popback();                // Removes and returns 30; Array: [10, 40]

int size = arr.getSize();                // Returns 2
int capacity = arr.getCapacity();        // Capacity might be 4 after resizing
