namespace Solution;

public static class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        var check = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            if (check.TryGetValue(target - nums[i], out var idx))
            {
                return [idx, i];
            }
            else
            {
                check.TryAdd(nums[i], i);
            }
        }
        return [];
    }
}