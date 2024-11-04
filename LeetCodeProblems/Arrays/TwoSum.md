# Two Sum

## Problem Description

Given an array of integers `nums` and an integer `target`, return the indices of the two numbers such that they add up to `target`.

You may assume that each input would have **exactly one solution**, and you may not use the **same element twice**.

You can return the answer in **any order**.

## Constraints

- `2 <= nums.length <= 10^4`
- `-10^9 <= nums[i] <= 10^9`
- `-10^9 <= target <= 10^9`
- Only one valid solution exists.

## Examples

### Example 1

**Input**: `nums = [2, 7, 11, 15]`, `target = 9`

**Output**: `[0, 1]`

**Explanation**: `nums[0] + nums[1] == 9`, so return `[0, 1]`.

### Example 2

**Input**: `nums = [3, 2, 4]`, `target = 6`

**Output**: `[1, 2]`

**Explanation**: `nums[1] + nums[2] == 6`, so return `[1, 2]`.

### Example 3

**Input**: `nums = [3, 3]`, `target = 6`

**Output**: `[0, 1]`

**Explanation**: `nums[0] + nums[1] == 6`, so return `[0, 1]`.

## Approach

To solve this problem efficiently, use a hash map (dictionary) to store each element's index as you iterate through `nums`. For each element, check if the `target` minus the current element exists in the hash map. If it does, you've found the solution.

## Pseudocode

```plaintext
function twoSum(nums, target):
    create empty hash_map
    for each index and number in nums:
        calculate complement as target - number
        if complement exists in hash_map:
            return indices of complement and current number
        add current number and its index to hash_map
    return empty array if no solution is found
