var result = new Solution().BuildArray(new int[] { 0, 2, 1, 5, 3, 4 });
var result2 = new Solution().BuildArray(new int[] { 5, 0, 1, 2, 3, 4 });

public class Solution
{
    public int[] BuildArray(int[] nums)
    {
        var result = new int[nums.Length];
        
        for(var i = 0; i < nums.Length; i++)
        {
            result[i] = nums[nums[i]];
        }

        return result;
    }
}



