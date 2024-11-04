namespace LeetCodeProblems.Arrays;

public static class TwoSum
{
    public static int[] FindTwoSum(int[] nums, int target)
    {
        Dictionary<int, int> lookup = new();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (lookup.ContainsKey(complement))
            {
                return new int[] { lookup[complement], i };
            }
            lookup[nums[i]] = i;
        }
        return new int[] { };
    }
}